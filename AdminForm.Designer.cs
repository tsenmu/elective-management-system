namespace ElectiveManagementSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_userManagement = new System.Windows.Forms.TabPage();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.tabPage_courseManagement = new System.Windows.Forms.TabPage();
            this.dataGridView_allCourses = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.department_course = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_systemManagement = new System.Windows.Forms.TabPage();
            this.dataGridView_system = new System.Windows.Forms.DataGridView();
            this.openSwitch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage_userManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.tabPage_courseManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allCourses)).BeginInit();
            this.tabPage_systemManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_system)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_userManagement);
            this.tabControl.Controls.Add(this.tabPage_courseManagement);
            this.tabControl.Controls.Add(this.tabPage_systemManagement);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(758, 567);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_userManagement
            // 
            this.tabPage_userManagement.Controls.Add(this.dataGridView_student);
            this.tabPage_userManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_userManagement.Name = "tabPage_userManagement";
            this.tabPage_userManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_userManagement.Size = new System.Drawing.Size(750, 541);
            this.tabPage_userManagement.TabIndex = 0;
            this.tabPage_userManagement.Text = "用户管理";
            this.tabPage_userManagement.UseVisualStyleBackColor = true;
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.AllowUserToOrderColumns = true;
            this.dataGridView_student.AllowUserToResizeRows = false;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.name,
            this.passwd,
            this.department});
            this.dataGridView_student.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowTemplate.Height = 23;
            this.dataGridView_student.Size = new System.Drawing.Size(744, 532);
            this.dataGridView_student.TabIndex = 0;
            this.dataGridView_student.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_student_CellLeave);
            // 
            // tabPage_courseManagement
            // 
            this.tabPage_courseManagement.Controls.Add(this.dataGridView_allCourses);
            this.tabPage_courseManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_courseManagement.Name = "tabPage_courseManagement";
            this.tabPage_courseManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_courseManagement.Size = new System.Drawing.Size(750, 541);
            this.tabPage_courseManagement.TabIndex = 1;
            this.tabPage_courseManagement.Text = "课程管理";
            this.tabPage_courseManagement.UseVisualStyleBackColor = true;
            // 
            // dataGridView_allCourses
            // 
            this.dataGridView_allCourses.AllowUserToResizeRows = false;
            this.dataGridView_allCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_allCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cname,
            this.ctime,
            this.course_detail,
            this.room,
            this.department_course,
            this.credit});
            this.dataGridView_allCourses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView_allCourses.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_allCourses.Name = "dataGridView_allCourses";
            this.dataGridView_allCourses.RowTemplate.Height = 23;
            this.dataGridView_allCourses.Size = new System.Drawing.Size(738, 529);
            this.dataGridView_allCourses.TabIndex = 0;
            this.dataGridView_allCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_allCourses_CellContentClick);
            this.dataGridView_allCourses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_allCourses_CellEndEdit);
            this.dataGridView_allCourses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_allCourses_CellFormatting);
            this.dataGridView_allCourses.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_allCourses_CellLeave);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "课程编号";
            this.cid.Name = "cid";
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "课程名称";
            this.cname.Name = "cname";
            // 
            // ctime
            // 
            this.ctime.DataPropertyName = "time";
            this.ctime.HeaderText = "上课时间";
            this.ctime.Name = "ctime";
            // 
            // course_detail
            // 
            this.course_detail.DataPropertyName = "detail";
            this.course_detail.HeaderText = "细节";
            this.course_detail.Name = "course_detail";
            // 
            // room
            // 
            this.room.DataPropertyName = "rid";
            this.room.HeaderText = "课程地点";
            this.room.Name = "room";
            this.room.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // department_course
            // 
            this.department_course.DataPropertyName = "did";
            this.department_course.HeaderText = "开课院所";
            this.department_course.Name = "department_course";
            this.department_course.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.department_course.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "学分数";
            this.credit.Name = "credit";
            // 
            // tabPage_systemManagement
            // 
            this.tabPage_systemManagement.Controls.Add(this.dataGridView_system);
            this.tabPage_systemManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_systemManagement.Name = "tabPage_systemManagement";
            this.tabPage_systemManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_systemManagement.Size = new System.Drawing.Size(750, 541);
            this.tabPage_systemManagement.TabIndex = 2;
            this.tabPage_systemManagement.Text = "系统管理";
            this.tabPage_systemManagement.UseVisualStyleBackColor = true;
            // 
            // dataGridView_system
            // 
            this.dataGridView_system.AllowUserToAddRows = false;
            this.dataGridView_system.AllowUserToDeleteRows = false;
            this.dataGridView_system.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_system.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.openSwitch});
            this.dataGridView_system.Location = new System.Drawing.Point(6, 3);
            this.dataGridView_system.Name = "dataGridView_system";
            this.dataGridView_system.RowTemplate.Height = 23;
            this.dataGridView_system.Size = new System.Drawing.Size(738, 532);
            this.dataGridView_system.TabIndex = 0;
            this.dataGridView_system.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_system_CellContentClick);
            // 
            // openSwitch
            // 
            this.openSwitch.DataPropertyName = "open";
            this.openSwitch.HeaderText = "选课系统开关";
            this.openSwitch.Name = "openSwitch";
            this.openSwitch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sid
            // 
            this.sid.DataPropertyName = "id";
            this.sid.HeaderText = "学号";
            this.sid.Name = "sid";
            // 
            // name
            // 
            this.name.DataPropertyName = "nm";
            this.name.HeaderText = "名字";
            this.name.Name = "name";
            // 
            // passwd
            // 
            this.passwd.DataPropertyName = "pw";
            this.passwd.HeaderText = "密码";
            this.passwd.Name = "passwd";
            // 
            // department
            // 
            this.department.DataPropertyName = "did";
            this.department.HeaderText = "学院";
            this.department.Name = "department";
            this.department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.department.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 586);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "学生选课系统（管理员模式）";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_userManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.tabPage_courseManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allCourses)).EndInit();
            this.tabPage_systemManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_system)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_userManagement;
        private System.Windows.Forms.TabPage tabPage_courseManagement;
        private System.Windows.Forms.TabPage tabPage_systemManagement;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.DataGridView dataGridView_allCourses;
        private System.Windows.Forms.DataGridView dataGridView_system;
        private System.Windows.Forms.DataGridViewCheckBoxColumn openSwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctime;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_detail;
        private System.Windows.Forms.DataGridViewComboBoxColumn room;
        private System.Windows.Forms.DataGridViewComboBoxColumn department_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwd;
        private System.Windows.Forms.DataGridViewComboBoxColumn department;
    }
}