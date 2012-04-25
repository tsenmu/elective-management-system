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
    public class Kernel
    {
        // These members maintained below are forms.
        private AdminForm adminForm;
        private UserForm userForm;
        private LoginForm loginForm;


        // These members maintained below are for database connections.
        private MySqlConnection  conn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader rdr = null;

        public Kernel(string server, string database, string userid, string password)
        {
            InitConnection(server, database, userid, password);
            loginForm = new LoginForm(this);
            loginForm.Show();
        }
        private void InitConnection(string server, string database, string userid, string password)
        {
            conn = new MySqlConnection("server="+
                server+";User Id="+userid+
                ";Password="+password+";database="
                +database);
        }
        public void Login(string id, string password, bool isAdmin)
        {
            if (isAdmin)
            {
                try
                {
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
                        if (CalculateMD5Hash(password).Equals(passwd))
                        {
                            succeeded = true;
                            break;
                        }
                    }
                    if (succeeded)
                    {
                        loginForm.Dispose();
                        adminForm = new AdminForm(this);
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User or password is invalid!");
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
                        if (CalculateMD5Hash(password).Equals(passwd))
                        {
                            succeeded = true;
                            break;
                        }
                    }
                    if (succeeded)
                    {
                        loginForm.Dispose();
                        userForm = new UserForm(this);
                        userForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User or password is invalid!");
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

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
 
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
