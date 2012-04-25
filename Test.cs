using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace ElectiveManagementSystem
{
    class Test : Form
    {
        private MySqlConnection conn;
        private MySqlDataAdapter da;

        private DataSet ds;
        private DataGrid dg;

        private const string tableName = "Animals";

        public  Test()
        {
            Initdata();
            dg = new DataGrid();
		dg.Location = new Point(5, 5);
		dg.Size = new Size(		
            this.ClientRectangle.Size.Width - 10,		
            this.ClientRectangle.Height - 50);
        MessageBox.Show(ds.GetXml());
		dg.DataSource = ds;
		dg.DataMember = tableName;

		// create update button
		Button btnUpdate = new Button();
		btnUpdate.Text = "Update";
		btnUpdate.Location = new Point(
			this.ClientRectangle.Width/2 - btnUpdate.Width/2,
			this.ClientRectangle.Height - (btnUpdate.Height + 10));
		btnUpdate.Click += new EventHandler(btnUpdateClicked);

		// make sure controls appear on form
		Controls.AddRange(new Control[] { dg, btnUpdate });
            
        }

        public bool Initdata()
        {
            string cs = @"server=localhost;userid=root;password=;database=utest";
            conn = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
                ds = new DataSet();
                da = new MySqlDataAdapter(
                    "select Weight, Colour, Age from Animals", conn);
                
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(da);

                da.Fill(ds, tableName);


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }
        public void btnUpdateClicked(Object sender, EventArgs e)
        {
            da.Update(ds, tableName);
        }
       /* static void Main()
        {
            
        }*/
    }
}
