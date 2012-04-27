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
        STUDENT,
        ALL_COURSES,
        SYSTEM,
        COLUMN_DEPARTMENT,
        COLUMN_ROOM,
        PERSONAL_INFORMATION,
        PASSWORD_UPDATE
    }

    public class SearchingCache
    {
        public SearchingCache()
        {
            courseID = "";
            courseName = "";
            isLastCommandSearch = false;
            department = "";
            view = null;
        }
        public string courseID{set; get;}
        public string courseName { set; get; }
        public string department { set; get; }
        public DataGridView view { set; get; }
        public bool isLastCommandSearch { set; get; }
    }

    public class PersonelInformation
    {
        public PersonelInformation(Label ID, Label name, Label department)
        {
            this.ID = ID;
            this.name = name;
            this.department = department;
        }
        public Label ID{set; get;}
        public Label name{set; get;}
        public Label department{set; get;}
    }

    public class PasswordInformation
    {
        public PasswordInformation(TextBox oldPassword, TextBox newPassword, TextBox confirm)
        {
            this.oldPassword = oldPassword;
            this.newPassword = newPassword;
            this.confirm = confirm;
        }
        public TextBox oldPassword { set; get; }
        public TextBox newPassword { set; get; }
        public TextBox confirm { set; get; }
    }
    public partial class Kernel
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
        /*StudentList*/
        private DataSet setStudentList = null;
        private MySqlDataAdapter adpStudentList = null;
        private MySqlCommandBuilder studentListCommandBuilder = null;
        /*All Courses*/
        private DataSet setAllCourses = null;
        private MySqlDataAdapter adpAllCourses = null;
        private MySqlCommandBuilder courseCommandBuilder = null;
        /*SYSTEM*/
        private DataSet setSystem = null;
        private MySqlDataAdapter adpSystem = null;
        private MySqlCommandBuilder systemCommandBuider = null;
        /*Column_department*/
        private DataSet setColumnDepartment = null;
        private MySqlDataAdapter adpColumnDepartment = null;
        /*Column_Room*/
        private DataSet setColumnRoom = null;
        private MySqlDataAdapter adpColumnRoom = null;
         /* Searching cache */
        private SearchingCache searchingCache;

        public Kernel(string server, string database, string userid, string password)
        {
            currentUserID = "";
            isAdmin = false;
            InitConnection(server, database, userid, password);
            searchingCache = new SearchingCache();
            loginForm = new LoginForm(this);
            loginForm.Show();
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
                + conn_database + ";CharSet=utf8;");
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
                    cmd = new MySqlCommand("select open from system;", conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (rdr[0].ToString() == "0")
                    {
                        MessageBox.Show("系统已经关闭了亲。");
                        return;
                    }
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
                loginForm.Dispose();
            }
            if (adminForm != null)
            {
                adminForm.Dispose();
            }
            if (userForm != null)
            {
                userForm.Dispose();
            }
            Application.Exit();
        }

        public void Load(KernelLoadModifier modifier, Object control)
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
                    adpUnselectedCourses = new MySqlDataAdapter(
                            cmd);
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
                    adpSelectedCourses = new MySqlDataAdapter(
                            cmd);
                    
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
                    adpDepartmentNames = new MySqlDataAdapter(
                            cmd);
                    
                    adpDepartmentNames.Fill(setDepartmentNames);
                    comboBox.DataSource = setDepartmentNames.Tables["Table"];
                    comboBox.DisplayMember = "department_name";
                }
                finally
                {
                }
            }
            else if (modifier == KernelLoadModifier.STUDENT)
            {
                try
                {
                    DataGridView view = (DataGridView)control;
                    conn = getConnection();
                    cmd = new MySqlCommand("SELECT * FROM Student;", conn);
                    if (setStudentList == null)
                    {
                        setStudentList = new DataSet();
                    }
                    else
                    {
                        setStudentList.Clear();
                    }
                    if (adpStudentList == null)
                    {
                        adpStudentList = new MySqlDataAdapter(
                            cmd);
                    }
                    studentListCommandBuilder = new MySqlCommandBuilder(adpStudentList);
                    adpStudentList.Fill(setStudentList);
                    view.DataSource = setStudentList;
                    view.DataMember = "Table";
                }
                finally
                {
                }
            }
            else if (modifier == KernelLoadModifier.ALL_COURSES)
            {
                try
                {
                    DataGridView view = (DataGridView)control;
                    conn = getConnection();
                    cmd = new MySqlCommand("SELECT * FROM course;", conn);
                    if (setAllCourses == null)
                        setAllCourses = new DataSet();
                    else
                        setAllCourses.Clear();
                    if (adpAllCourses == null)
                        adpAllCourses = new MySqlDataAdapter(cmd);
                    courseCommandBuilder = new MySqlCommandBuilder(adpAllCourses);
                    adpAllCourses.Fill(setAllCourses);
                    view.DataSource = setAllCourses;
                    view.DataMember = "Table";
                }
                finally
                {
                }
            }
            else if (modifier == KernelLoadModifier.SYSTEM) 
            {
                CheckBox cb = (CheckBox)control;
                conn = getConnection();
                cmd = new MySqlCommand("select open from system;", conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Int32 open = Convert.ToInt32(reader[0].ToString());
                if (open == 0)
                    cb.Checked = false;
                else                  
                    cb.Checked = true;
            }
            else if (modifier == KernelLoadModifier.COLUMN_DEPARTMENT)
            {
                DataGridViewComboBoxColumn cb = (DataGridViewComboBoxColumn)control;
                conn = getConnection();
                cmd = new MySqlCommand("select * from department;", conn);
                if (setColumnDepartment == null)
                    setColumnDepartment = new DataSet();
                else
                    setColumnDepartment.Clear();
                if (adpColumnDepartment == null)
                    adpColumnDepartment = new MySqlDataAdapter(cmd);
                adpColumnDepartment.Fill(setColumnDepartment);
                cb.DataSource = setColumnDepartment;
                cb.ValueMember = "Table.did";
                cb.DisplayMember = "Table.name";
            }
            else if (modifier == KernelLoadModifier.COLUMN_ROOM)
            {
                DataGridViewComboBoxColumn cb = (DataGridViewComboBoxColumn)control;
                conn = getConnection();
                cmd = new MySqlCommand("select * from room;", conn);
                if (setColumnRoom == null)
                    setColumnRoom = new DataSet();
                else
                    setColumnRoom.Clear();
                if (adpColumnRoom == null)
                    adpColumnRoom = new MySqlDataAdapter(cmd);
                adpColumnRoom.Fill(setColumnRoom);
                cb.DataSource = setColumnRoom;
                cb.ValueMember = "Table.rid";
                cb.DisplayMember = "Table.name";
            }
            else if (modifier == KernelLoadModifier.PERSONAL_INFORMATION)
            {
                PersonelInformation info = (PersonelInformation)control;
                conn = getConnection();
                conn.Open();
                cmd = new MySqlCommand("select student.sid as stuid, student.name as sname, department.name as dname from student join department where sid = @student_id and department.did = student.did;", conn);
                cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {


                        info.ID.Text = (string)rdr["stuid"];
                        info.name.Text = (string)rdr["sname"];
                        info.department.Text = (string)rdr["dname"];
                        break;

                    }
                }
                catch (Exception e)
                {
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    if( rdr != null)
                    {
                        rdr.Close();
                    }
                }

            }
        }
        
        public void update(KernelLoadModifier modifier)
        {
            if (modifier == KernelLoadModifier.ALL_COURSES)
            {
                adpAllCourses.Update(setAllCourses);
            }
            if (modifier == KernelLoadModifier.STUDENT)
            {
                adpStudentList.Update(setStudentList);
            }
        }
        public void update(KernelLoadModifier modifier, CheckBox cb)
        {
            if (modifier == KernelLoadModifier.SYSTEM)
            {
                conn = getConnection();
                conn.Open();
                cmd = new MySqlCommand("UPDATE SYSTEM SET OPEN = @open", conn);
                cmd.Parameters.Add(new MySqlParameter("@open", cb.Checked == true ? 1 : 0));
                cmd.ExecuteNonQuery();
            }
        }

        public void Search(string courseID, string courseName, string department, DataGridView view)
        {

            try
            {
                conn = getConnection();
                cmd = new MySqlCommand(
                    "searchUnselectedCourses", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new  MySqlParameter("@course_id", courseID));
                cmd.Parameters.Add(new MySqlParameter("@course_name", courseName));
                cmd.Parameters.Add(new MySqlParameter("@department_name", department));
                cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));
                if (setSearchResults == null)
                {
                    setSearchResults = new DataSet();
                }
                else
                {
                    setSearchResults.Clear();
                }

                adpSearchResults = new MySqlDataAdapter(cmd);
                adpSearchResults.Fill(setSearchResults);
                view.DataSource = setSearchResults;
                view.DataMember = "Table";
                FillSearchingCache(courseID, courseName, department, view);
            }
            finally
            {

            }
        }

        private void FillSearchingCache(string courseID, string courseName, string department, DataGridView view)
        {
            searchingCache.courseID = courseID;
            searchingCache.courseName = courseName;
            searchingCache.department = department;
            searchingCache.view = view;
            searchingCache.isLastCommandSearch = true;
        }

        private void ReloadUserForm()
        {
            if (userForm != null)
            {
                userForm.Reload(searchingCache.isLastCommandSearch, searchingCache);
            }
        }
        public void SelectCourse(DataGridView view)
        {
            if (view.RowCount == 0)
            {
                MessageBox.Show("你没有选择任何项！");
                return;
            }
            try
            {
                String cid = view.SelectedRows[0].Cells["u_id"].Value.ToString();
                conn = getConnection();
                conn.Open();
                cmd = new MySqlCommand(
                    "selectCourse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));
                cmd.Parameters.Add(new MySqlParameter("@course_id", cid));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                ReloadUserForm();
            }
        }

        public void UnselectCourse(DataGridView view)
        {
            if (view.RowCount == 0)
            {
                MessageBox.Show("你没有选择任何项！");
                return;
            }
            try
            {
                String cid = view.SelectedRows[0].Cells["s_id"].Value.ToString();
                conn = getConnection();
                conn.Open();
                cmd = new MySqlCommand(
                    "unselectCourse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));
                cmd.Parameters.Add(new MySqlParameter("@course_id", cid));
                cmd.ExecuteNonQuery();
                
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                ReloadUserForm();
            }
        }
        }

        public void ChangePassword(PasswordInformation info)
        {
            string oldPassword = info.oldPassword.Text.Trim();
            string newPassword = info.newPassword.Text.Trim();
            string confirm = info.confirm.Text.Trim();
            bool succeeded = false;
            try {
                conn = getConnection();
                conn.Open();
                cmd = new MySqlCommand(
                    "getStudentPassword", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@student_id", currentUserID));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string passwd = (string)rdr["passwd"];
                    if (Utils.CalculateMD5Hash(oldPassword).Equals(passwd))
                    {
                        succeeded = true;
                        break;
                    }
                }
            } 
            catch (Exception e)
            {

            }
            finally 
            {
                if(conn == null)
                {
                    conn.Close();
                }
                if(rdr == null)
                {
                    rdr.Close();
                }

            }
            
            if (succeeded)
            {
                //bool empty = false;
                if (newPassword == "")
                {
                    MessageBox.Show("新密码不能为空！");
                    return;
                }
                if (confirm == "")
                {
                    MessageBox.Show("新密码验证不能为空！");
                    return;
                }
                if (newPassword != confirm)
                {
                    MessageBox.Show("新密码不相符！");
                    return; 
                }
                if (newPassword == confirm)
                {
                    try
                    {
                        conn = getConnection();
                        conn.Open();
                        cmd = new MySqlCommand("update student set passwd = @pass where sid = @student_id", conn);
                        cmd.Parameters.AddWithValue("@pass", Utils.CalculateMD5Hash(newPassword));
                        cmd.Parameters.AddWithValue("@student_id", currentUserID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功！");
                    }
                    catch (Exception e)
                    {

                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
    }
}
