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
            kernel.Load("UNSELECTED_COURSES", dataGridView_unselectedCourses);
            kernel.Load("SELECTED_COURSES", dataGridView_selectedCourses);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kernel.Close();
        }

        private void dataGridView_selectedCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_selectedCourses.CurrentRow != null)
            {
                dataGridView_selectedCourses.CurrentRow.Selected = true;
            }
        }

        private void dataGridView_unselectedCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_unselectedCourses.CurrentRow != null)
            {
                dataGridView_unselectedCourses.CurrentRow.Selected = true;
            }
        }

        private void dataGridView_selectedCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
            if (dataGridView_selectedCourses.Columns[e.ColumnIndex].HeaderText == "上课时间")
            {
                MessageBox.Show((string)e.Value);
                e.Value = Utils.DecodeTime(e.Value.ToString());
            }
        }

    }
}
