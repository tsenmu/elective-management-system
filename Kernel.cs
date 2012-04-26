using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace ElectiveManagementSystem
{
    public enum KernelLoadModifier
    {
        UNSELECTED_COURSES,
        SELECTED_COURSES,
        DEPARTMENT,
    }
    public class Kernel
    {
        // These members maintained below are forms.
        private AdminForm adminForm;
        private UserForm userForm;
        private LoginForm loginForm;

        // Holds the current user information.
        private string currentUserID;
        private bool isAdmin;

        /* Connection information */
        private string conn_server;
        private string conn_database;
        private string conn_userid;
        private string conn_passwd;

        /* These members maintained below are for database connections.*/
        private MySqlConnection  conn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader rdr = null;
        
        /* These are more specified variables. */
        /* UnselectedCourses */
        private DataSet setUnselectedCourses = null;
        private MySqlDataAdapter adpUnselectedCourses = null;
        /* SelectedCourses */
        private DataSet setSelectedCourses = null;
        private MySqlDataAdapter adpSelectedCourses = null;
        /* DepartmentNames */
        private DataSet setDepartmentNames = null;
        private MySqlDataAdapter adpDepartmentNames = null;
        /* SearchUnselectedCourses */
        private DataSet setSearchResults = null;
        private MySqlDataAdapter adpSearchResults = null;

        public Kernel(string server, string database, string userid, string password)
        {
            currentUserID = "";
            isAdmin = false;
            InitConnection(server, database, userid, password);
            loginForm = new LoginForm(this);
            loginForm.Show();
            Utils.DecodeTime("");
            Console.WriteLine("Kernel started");
        }
        private void InitConnection(string server, string database, string userid, string password)
        {
            conn_server = server;
            conn_database = database;
            conn_userid = userid;
            conn_passwd = password;
        }
        private MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection("server=" +
                conn_server + ";User Id=" + conn_userid +
                ";Password=" + conn_passwd + ";database="
                + conn_database);
            return conn;
        }
        public void Login(string id, string password, bool isAdmin)
        {
            if (isAdmin)
            {
                try
                {
                    conn = getConnection();
                    conn.Open();
                    cmd = new MySqlCommand(
                        "getAdminPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@admin_id", id));
                    rdr = cmd.ExecuteReader();

                    bool succeeded = false;
                    while (rdr.Read())
                    {
                        string passwd = (string)rdr["passwd"];
                        if (Utils.CalculateMD5Hash(password).Equals(passwd))
                        {
                            succeeded = true;
                            break;
                        }
                    }
                    if (succeeded)
                    {
                        currentUserID = id;
                        this.isAdmin = true;
                        loginForm.Dispose();
                        adminForm = new AdminForm(this);
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                    }
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }
            }
            else
            {
                try
                {
                    conn = getConnection();
                    conn.Open();
                    cmd = new MySqlCommand(
                        "getStudentPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@student_id", id));
                    rdr = cmd.ExecuteReader();

                    bool succeeded = false;
                    while (rdr.Read())
                    {
                        string passwd = (string)rdr["passwd"];
                        if (Utils.CalculateMD5Hash(password).Equals(passwd))
                        {
                            succeeded = true;
                            break;
                        }
                    }
                    if (succeeded)
                    {
                        this.currentUserID = id;
                        isAdmin = false;
                        loginForm.Dispose();
                        userForm = new UserForm(this);
                        userForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                    }
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }
            }
        }

        public void Close()
        {
            if (loginForm != null)
            {
                loginForm.Close();
            }
            if (adminForm != null)
            {
                adminForm.Close();
            }
            if (userForm != null)
            {
                userForm.Close();
            }
            Application.Exit();
        }

        public void Load(KernelLoadModifier modifier, Control control)
        {
            if(modifier == KernelLoadModifier.UNSELECTED_COURSES)
            {
                try
                {
                    DataGridView view = (DataGridView)control;
                    conn = getConnection();
                    //conn.Open();
                    cmd = new MySqlCommand(
                        "getUnselectedCourses", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));

                    if (setUnselectedCourses == null)
                    {
                        setUnselectedCourses = new DataSet();
                    }
                    else
                    {
                        setUnselectedCourses.Clear();
                    }
                    if (adpUnselectedCourses == null)
                    {
                        adpUnselectedCourses = new MySqlDataAdapter(
                            cmd);
                    }
                    adpUnselectedCourses.Fill(setUnselectedCourses);
                  //  setUnselectedCourses.Tables.
                    view.DataSource = setUnselectedCourses;
                    view.DataMember = "Table";
                }
                finally
                {
                  
                }
            }
            else if(modifier == KernelLoadModifier.SELECTED_COURSES)
            {
                try
                {
                    DataGridView view = (DataGridView)control;
                    conn = getConnection();
                    //conn.Open();
                    cmd = new MySqlCommand(
                        "getSelectedCourses", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));

                    if (setSelectedCourses == null)
                    {
                        setSelectedCourses = new DataSet();
                    }
                    else
                    {
                        setSelectedCourses.Clear();
                    }
                    if (adpSelectedCourses == null)
                    {
                        adpSelectedCourses = new MySqlDataAdapter(
                            cmd);
                    }
                    adpSelectedCourses.Fill(setSelectedCourses);
                    view.DataSource = setSelectedCourses;
                    view.DataMember = "Table";
                }
                finally
                {
                }
            }
            else if (modifier == KernelLoadModifier.DEPARTMENT)
            {
                
                try
                {
                    ComboBox comboBox = (ComboBox)control;
                    conn = getConnection();
                    //conn.Open();
                    cmd = new MySqlCommand(
                        "getDepartmentNames", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (setDepartmentNames == null)
                    {
                        setDepartmentNames = new DataSet();
                    }
                    else
                    {
                        setDepartmentNames.Clear();
                    }
                    if (adpDepartmentNames == null)
                    {
                        adpDepartmentNames = new MySqlDataAdapter(
                            cmd);
                    }
                    adpDepartmentNames.Fill(setDepartmentNames);
                    comboBox.DataSource = setDepartmentNames.Tables["Table"];
                    comboBox.DisplayMember = "department_name";
                }
                finally
                {
                }
            }
        }

        public void Search(string courseID, string courseName, string department, DataGridView view)
        {
            try
            {
                conn = getConnection();
                //conn.Open();
                cmd = new MySqlCommand(
                    "searchUnselectedCourses", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@course_id", courseID));
                cmd.Parameters.Add(new MySqlParameter("@course_name", courseName));
                cmd.Parameters.Add(new MySqlParameter("@department_name", department));
                if (setSearchResults == null)
                {
                    setSearchResults = new DataSet();
                }
                else
                {
                    setSearchResults.Clear();
                }
                if (adpSearchResults == null)
                {
                    adpSearchResults = new MySqlDataAdapter(
                        cmd);
                }
                adpUnselectedCourses.Fill(setSearchResults);
                //  setUnselectedCourses.Tables.
                view.DataSource = setSearchResults;
                view.DataMember = "Table";
            }
            finally
            {

            }
        }
    }
}
