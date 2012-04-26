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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_userManagement = new System.Windows.Forms.TabPage();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_courseManagement = new System.Windows.Forms.TabPage();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.dataGridView_allCourses = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_systemManagement = new System.Windows.Forms.TabPage();
            this.dataGridView_system = new System.Windows.Forms.DataGridView();
            this.openSwitch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "学院";
            this.department.Name = "department";
            // 
            // tabPage_courseManagement
            // 
            this.tabPage_courseManagement.Controls.Add(this.deleteCourseButton);
            this.tabPage_courseManagement.Controls.Add(this.addCourseButton);
            this.tabPage_courseManagement.Controls.Add(this.dataGridView_allCourses);
            this.tabPage_courseManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_courseManagement.Name = "tabPage_courseManagement";
            this.tabPage_courseManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_courseManagement.Size = new System.Drawing.Size(750, 541);
            this.tabPage_courseManagement.TabIndex = 1;
            this.tabPage_courseManagement.Text = "课程管理";
            this.tabPage_courseManagement.UseVisualStyleBackColor = true;
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteCourseButton.Image")));
            this.deleteCourseButton.Location = new System.Drawing.Point(110, 501);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(27, 27);
            this.deleteCourseButton.TabIndex = 2;
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Image = ((System.Drawing.Image)(resources.GetObject("addCourseButton.Image")));
            this.addCourseButton.Location = new System.Drawing.Point(62, 501);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(27, 27);
            this.addCourseButton.TabIndex = 1;
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
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
            this.rid,
            this.department_course,
            this.credit});
            this.dataGridView_allCourses.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_allCourses.Name = "dataGridView_allCourses";
            this.dataGridView_allCourses.RowTemplate.Height = 23;
            this.dataGridView_allCourses.Size = new System.Drawing.Size(738, 489);
            this.dataGridView_allCourses.TabIndex = 0;
            this.dataGridView_allCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_allCourses_CellContentClick);
            this.dataGridView_allCourses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_allCourses_CellFormatting);
            this.dataGridView_allCourses.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_allCourses_CellLeave);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id";
            this.cid.HeaderText = "课程编号";
            this.cid.Name = "cid";
            // 
            // cname
            // 
            this.cname.DataPropertyName = "course";
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
            // rid
            // 
            this.rid.DataPropertyName = "room";
            this.rid.HeaderText = "课程地点";
            this.rid.Name = "rid";
            // 
            // department_course
            // 
            this.department_course.DataPropertyName = "department";
            this.department_course.HeaderText = "开课院所";
            this.department_course.Name = "department_course";
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 591);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridView dataGridView_allCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctime;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn rid;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridView dataGridView_system;
        private System.Windows.Forms.DataGridViewCheckBoxColumn openSwitch;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button deleteCourseButton;
    }
}