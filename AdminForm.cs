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
        int newCourseRow, newStudentRow;
        public AdminForm(Kernel kernel)
        {
            this.kernel = kernel;
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            kernel.Load(KernelLoadModifier.STUDENT, dataGridView_student);
            kernel.Load(KernelLoadModifier.ALL_COURSES, dataGridView_allCourses);
            kernel.Load(KernelLoadModifier.SYSTEM, dataGridView_system);
            newCourseRow = dataGridView_allCourses.NewRowIndex;
            newStudentRow = dataGridView_student.NewRowIndex;
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
                if (e.Value != null)
                    e.Value = Utils.DecodeTime(e.Value.ToString());
            }
        }

        private void dataGridView_system_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_system.Columns[e.ColumnIndex].HeaderText == "选课系统开关")
                ;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            //string cid = InputBox(message, title, defaultValue);
            
        }

        private void dataGridView_allCourses_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            kernel.update(KernelLoadModifier.ALL_COURSES);
        }

    }
}
