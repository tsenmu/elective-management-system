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
    public partial class AdminForm : Form
    {
        private Kernel kernel;
        public AdminForm(Kernel kernel)
        {
            this.kernel = kernel;
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kernel.Close();
        }
    }
}
