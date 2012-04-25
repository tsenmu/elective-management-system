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
    public partial class UserForm : Form
    {
        private Kernel kernel;

        public UserForm(Kernel kernel)
        {
            this.kernel = kernel;
            InitializeComponent();
        }


        private void dataGridView_selectedCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kernel.Close();
        }
    }
}
