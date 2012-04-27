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
            InitializeComponentProperties();
            
        }

        private void InitializeComponentProperties()
        {
            dataGridView_selectedCourses.ReadOnly = true;
            dataGridView_unselectedCourses.ReadOnly = true;
            dataGridView_schedule.ReadOnly = true;
            dataGridView_selectedCourses.AllowUserToAddRows = false;
            dataGridView_unselectedCourses.AllowUserToAddRows = false;
            dataGridView_schedule.AllowUserToAddRows = false;
            dataGridView_unselectedCourses.AllowUserToDeleteRows = false;
            dataGridView_selectedCourses.AllowUserToDeleteRows = false;
            dataGridView_schedule.AllowUserToDeleteRows = false;
        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            kernel.Load(KernelLoadModifier.UNSELECTED_COURSES, dataGridView_unselectedCourses);
            kernel.Load(KernelLoadModifier.SELECTED_COURSES, dataGridView_selectedCourses);
            kernel.Load(KernelLoadModifier.DEPARTMENT, comboBox_department);
            kernel.Load(KernelLoadModifier.PERSONAL_INFORMATION, new PersonelInformation(label_name, label_ID, label_department));
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kernel.Close();
        }

        private void dataGridView_selectedCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
            if (dataGridView_selectedCourses.Columns[e.ColumnIndex].HeaderText == "上课时间")
            {
                e.Value = Utils.DecodeTime(e.Value.ToString());
            }
        }

        private void dataGridView_unselectedCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_selectedCourses.Columns[e.ColumnIndex].HeaderText == "上课时间")
            {
                e.Value = Utils.DecodeTime(e.Value.ToString());
            }
        }


        public void Reload(bool isLastCommandSearch, SearchingCache sc)
        {
            if (isLastCommandSearch)
            {
                kernel.Search(sc.courseID, sc.courseName, sc.department, dataGridView_unselectedCourses);
                kernel.Load(KernelLoadModifier.SELECTED_COURSES, dataGridView_selectedCourses);
                kernel.Load(KernelLoadModifier.DEPARTMENT, comboBox_department);
            }
            else
            {
                kernel.Load(KernelLoadModifier.UNSELECTED_COURSES, dataGridView_unselectedCourses);
                kernel.Load(KernelLoadModifier.SELECTED_COURSES, dataGridView_selectedCourses);
                kernel.Load(KernelLoadModifier.DEPARTMENT, comboBox_department);
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            kernel.Search(textBox_courseID.Text, textBox_courseName.Text, comboBox_department.Text, dataGridView_unselectedCourses);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            kernel.UnselectCourse(dataGridView_selectedCourses);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            kernel.SelectCourse(dataGridView_unselectedCourses);
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            kernel.ChangePassword(new PasswordInformation
                (textBox_oldPassword,
                textBox_newPassword,
                textBox_newPasswordConfirm));
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_oldPassword.Clear();
            textBox_newPassword.Clear();
            textBox_newPasswordConfirm.Clear();
        }

       

    }
}
