﻿using System;
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
        /*All Courses*/
        private DataSet setAllCourses = null;
        private MySqlDataAdapter adpAllCourses = null;
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
                    cmd = new MySqlCommand(
                        "getStudentList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

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
                    adpStudentList.Fill(setStudentList);
                    //  setUnselectedCourses.Tables.
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
                    cmd = new MySqlCommand(
                        "getAllCourses", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (setAllCourses == null)
                        setAllCourses = new DataSet();
                    else
                        setAllCourses.Clear();
                    if (adpAllCourses == null)
                        adpAllCourses = new MySqlDataAdapter(cmd);
                    adpAllCourses.Fill(setAllCourses);
                    view.DataSource = setAllCourses;
                    view.DataMember = "Table";
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
            }
            finally
            {

            }
        }
    }
}
