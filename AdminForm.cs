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
            kernel.Load(KernelLoadModifier.STUDENT, dataGridView_student);
            kernel.Load(KernelLoadModifier.ALL_COURSES, dataGridView_allCourses);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kernel.Close();
        }

        private void dataGridView_allCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_allCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_allCourses.Columns[e.ColumnIndex].HeaderText == "上课时间")
            {
                //e.Value = Utils.DecodeTime(e.Value.ToString());
            }
        }
    }
}
