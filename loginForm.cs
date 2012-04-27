using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElectiveManagementSystem
{
    public partial class LoginForm : Form
    {
        private Kernel kernel;

        public LoginForm(Kernel kernel)
        {
            this.kernel = kernel;
            InitializeComponent();
        }

        private void checkBox_isAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void userLoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            kernel.Login(this.textBox_user.Text, this.textBox_password.Text,
                this.checkBoxIsAdmin.Checked);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            kernel.Close();
        } 

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kernel.Close();
        }

        private void button_passwordForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("忘掉就忘掉吧！旧的不去，新的不来。。。");
        }
    }
}
