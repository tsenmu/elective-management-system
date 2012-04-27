namespace ElectiveManagementSystem
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_electiveManagement = new System.Windows.Forms.TabPage();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.comboBox_department = new System.Windows.Forms.ComboBox();
            this.label_courseDepartment = new System.Windows.Forms.Label();
            this.textBox_courseName = new System.Windows.Forms.TextBox();
            this.label_courseName = new System.Windows.Forms.Label();
            this.label_courseID = new System.Windows.Forms.Label();
            this.textBox_courseID = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_unselectedCourses = new System.Windows.Forms.Label();
            this.label_SelectedCourses = new System.Windows.Forms.Label();
            this.dataGridView_unselectedCourses = new System.Windows.Forms.DataGridView();
            this.u_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_selectedCourses = new System.Windows.Forms.DataGridView();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_schedule = new System.Windows.Forms.TabPage();
            this.dataGridView_schedule = new System.Windows.Forms.DataGridView();
            this.tabPage_information = new System.Windows.Forms.TabPage();
            this.groupBox_information = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_ro_ID = new System.Windows.Forms.Label();
            this.label_ro_name = new System.Windows.Forms.Label();
            this.label_ro_department = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_department = new System.Windows.Forms.Label();
            this.label_ro_oldPassword = new System.Windows.Forms.Label();
            this.label_ro_newPassword = new System.Windows.Forms.Label();
            this.label_ro_repeatNewPassword = new System.Windows.Forms.Label();
            this.textBox_oldPassword = new System.Windows.Forms.TextBox();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.textBox_newPasswordConfirm = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_electiveManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_unselectedCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedCourses)).BeginInit();
            this.tabPage_schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).BeginInit();
            this.tabPage_information.SuspendLayout();
            this.groupBox_information.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_electiveManagement);
            this.tabControl.Controls.Add(this.tabPage_schedule);
            this.tabControl.Controls.Add(this.tabPage_information);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 632);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_electiveManagement
            // 
            this.tabPage_electiveManagement.Controls.Add(this.button_add);
            this.tabPage_electiveManagement.Controls.Add(this.button_remove);
            this.tabPage_electiveManagement.Controls.Add(this.comboBox_department);
            this.tabPage_electiveManagement.Controls.Add(this.label_courseDepartment);
            this.tabPage_electiveManagement.Controls.Add(this.textBox_courseName);
            this.tabPage_electiveManagement.Controls.Add(this.label_courseName);
            this.tabPage_electiveManagement.Controls.Add(this.label_courseID);
            this.tabPage_electiveManagement.Controls.Add(this.textBox_courseID);
            this.tabPage_electiveManagement.Controls.Add(this.button_search);
            this.tabPage_electiveManagement.Controls.Add(this.label_unselectedCourses);
            this.tabPage_electiveManagement.Controls.Add(this.label_SelectedCourses);
            this.tabPage_electiveManagement.Controls.Add(this.dataGridView_unselectedCourses);
            this.tabPage_electiveManagement.Controls.Add(this.dataGridView_selectedCourses);
            this.tabPage_electiveManagement.Location = new System.Drawing.Point(4, 21);
            this.tabPage_electiveManagement.Name = "tabPage_electiveManagement";
            this.tabPage_electiveManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_electiveManagement.Size = new System.Drawing.Size(793, 607);
            this.tabPage_electiveManagement.TabIndex = 0;
            this.tabPage_electiveManagement.Text = "选课退课";
            this.tabPage_electiveManagement.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Image = ((System.Drawing.Image)(resources.GetObject("button_add.Image")));
            this.button_add.Location = new System.Drawing.Point(8, 577);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(27, 27);
            this.button_add.TabIndex = 12;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_remove.BackgroundImage")));
            this.button_remove.Location = new System.Drawing.Point(8, 216);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(27, 27);
            this.button_remove.TabIndex = 11;
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // comboBox_department
            // 
            this.comboBox_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_department.FormattingEnabled = true;
            this.comboBox_department.Location = new System.Drawing.Point(480, 243);
            this.comboBox_department.Name = "comboBox_department";
            this.comboBox_department.Size = new System.Drawing.Size(121, 20);
            this.comboBox_department.TabIndex = 10;
            // 
            // label_courseDepartment
            // 
            this.label_courseDepartment.AutoSize = true;
            this.label_courseDepartment.Location = new System.Drawing.Point(415, 247);
            this.label_courseDepartment.Name = "label_courseDepartment";
            this.label_courseDepartment.Size = new System.Drawing.Size(59, 12);
            this.label_courseDepartment.TabIndex = 9;
            this.label_courseDepartment.Text = "开课院所:";
            // 
            // textBox_courseName
            // 
            this.textBox_courseName.Location = new System.Drawing.Point(309, 242);
            this.textBox_courseName.Name = "textBox_courseName";
            this.textBox_courseName.Size = new System.Drawing.Size(100, 21);
            this.textBox_courseName.TabIndex = 8;
            // 
            // label_courseName
            // 
            this.label_courseName.AutoSize = true;
            this.label_courseName.Location = new System.Drawing.Point(255, 247);
            this.label_courseName.Name = "label_courseName";
            this.label_courseName.Size = new System.Drawing.Size(47, 12);
            this.label_courseName.TabIndex = 7;
            this.label_courseName.Text = "课程名:";
            // 
            // label_courseID
            // 
            this.label_courseID.AutoSize = true;
            this.label_courseID.Location = new System.Drawing.Point(89, 247);
            this.label_courseID.Name = "label_courseID";
            this.label_courseID.Size = new System.Drawing.Size(59, 12);
            this.label_courseID.TabIndex = 6;
            this.label_courseID.Text = "课程编号:";
            // 
            // textBox_courseID
            // 
            this.textBox_courseID.Location = new System.Drawing.Point(148, 242);
            this.textBox_courseID.Name = "textBox_courseID";
            this.textBox_courseID.Size = new System.Drawing.Size(100, 21);
            this.textBox_courseID.TabIndex = 5;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(687, 240);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_unselectedCourses
            // 
            this.label_unselectedCourses.AutoSize = true;
            this.label_unselectedCourses.Location = new System.Drawing.Point(4, 247);
            this.label_unselectedCourses.Name = "label_unselectedCourses";
            this.label_unselectedCourses.Size = new System.Drawing.Size(53, 12);
            this.label_unselectedCourses.TabIndex = 3;
            this.label_unselectedCourses.Text = "待选课程";
            // 
            // label_SelectedCourses
            // 
            this.label_SelectedCourses.AutoSize = true;
            this.label_SelectedCourses.Location = new System.Drawing.Point(6, 9);
            this.label_SelectedCourses.Name = "label_SelectedCourses";
            this.label_SelectedCourses.Size = new System.Drawing.Size(53, 12);
            this.label_SelectedCourses.TabIndex = 2;
            this.label_SelectedCourses.Text = "已选课程";
            // 
            // dataGridView_unselectedCourses
            // 
            this.dataGridView_unselectedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_unselectedCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.u_id,
            this.u_course,
            this.u_department,
            this.u_room,
            this.u_time,
            this.u_detail});
            this.dataGridView_unselectedCourses.Location = new System.Drawing.Point(6, 271);
            this.dataGridView_unselectedCourses.Name = "dataGridView_unselectedCourses";
            this.dataGridView_unselectedCourses.RowTemplate.Height = 23;
            this.dataGridView_unselectedCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_unselectedCourses.Size = new System.Drawing.Size(781, 300);
            this.dataGridView_unselectedCourses.TabIndex = 1;
            this.dataGridView_unselectedCourses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_unselectedCourses_CellFormatting);
            // 
            // u_id
            // 
            this.u_id.DataPropertyName = "id";
            this.u_id.HeaderText = "课程编号";
            this.u_id.Name = "u_id";
            // 
            // u_course
            // 
            this.u_course.DataPropertyName = "course";
            this.u_course.HeaderText = "课程名称";
            this.u_course.Name = "u_course";
            // 
            // u_department
            // 
            this.u_department.DataPropertyName = "department";
            this.u_department.HeaderText = "开课院所";
            this.u_department.Name = "u_department";
            // 
            // u_room
            // 
            this.u_room.DataPropertyName = "room";
            this.u_room.HeaderText = "上课地点";
            this.u_room.Name = "u_room";
            // 
            // u_time
            // 
            this.u_time.DataPropertyName = "time";
            this.u_time.HeaderText = "上课时间";
            this.u_time.Name = "u_time";
            // 
            // u_detail
            // 
            this.u_detail.DataPropertyName = "detail";
            this.u_detail.HeaderText = "备注";
            this.u_detail.Name = "u_detail";
            // 
            // dataGridView_selectedCourses
            // 
            this.dataGridView_selectedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectedCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.s_course,
            this.s_department,
            this.s_room,
            this.s_time,
            this.s_detail});
            this.dataGridView_selectedCourses.Location = new System.Drawing.Point(6, 24);
            this.dataGridView_selectedCourses.Name = "dataGridView_selectedCourses";
            this.dataGridView_selectedCourses.RowTemplate.Height = 23;
            this.dataGridView_selectedCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_selectedCourses.Size = new System.Drawing.Size(781, 186);
            this.dataGridView_selectedCourses.TabIndex = 0;
            this.dataGridView_selectedCourses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_selectedCourses_CellFormatting);
            // 
            // s_id
            // 
            this.s_id.DataPropertyName = "id";
            this.s_id.HeaderText = "课程编号";
            this.s_id.Name = "s_id";
            // 
            // s_course
            // 
            this.s_course.DataPropertyName = "course";
            this.s_course.HeaderText = "课程名称";
            this.s_course.Name = "s_course";
            // 
            // s_department
            // 
            this.s_department.DataPropertyName = "department";
            this.s_department.HeaderText = "开课院所";
            this.s_department.Name = "s_department";
            // 
            // s_room
            // 
            this.s_room.DataPropertyName = "room";
            this.s_room.HeaderText = "上课地点";
            this.s_room.Name = "s_room";
            // 
            // s_time
            // 
            this.s_time.DataPropertyName = "time";
            this.s_time.HeaderText = "上课时间";
            this.s_time.Name = "s_time";
            // 
            // s_detail
            // 
            this.s_detail.DataPropertyName = "detail";
            this.s_detail.HeaderText = "备注";
            this.s_detail.Name = "s_detail";
            // 
            // tabPage_schedule
            // 
            this.tabPage_schedule.Controls.Add(this.dataGridView_schedule);
            this.tabPage_schedule.Location = new System.Drawing.Point(4, 21);
            this.tabPage_schedule.Name = "tabPage_schedule";
            this.tabPage_schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_schedule.Size = new System.Drawing.Size(793, 607);
            this.tabPage_schedule.TabIndex = 1;
            this.tabPage_schedule.Text = "课表";
            this.tabPage_schedule.UseVisualStyleBackColor = true;
            // 
            // dataGridView_schedule
            // 
            this.dataGridView_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_schedule.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_schedule.Name = "dataGridView_schedule";
            this.dataGridView_schedule.RowTemplate.Height = 23;
            this.dataGridView_schedule.Size = new System.Drawing.Size(781, 573);
            this.dataGridView_schedule.TabIndex = 0;
            // 
            // tabPage_information
            // 
            this.tabPage_information.Controls.Add(this.groupBox2);
            this.tabPage_information.Controls.Add(this.groupBox_information);
            this.tabPage_information.Location = new System.Drawing.Point(4, 21);
            this.tabPage_information.Name = "tabPage_information";
            this.tabPage_information.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_information.Size = new System.Drawing.Size(793, 607);
            this.tabPage_information.TabIndex = 2;
            this.tabPage_information.Text = "个人设置";
            this.tabPage_information.UseVisualStyleBackColor = true;
            // 
            // groupBox_information
            // 
            this.groupBox_information.Controls.Add(this.label_department);
            this.groupBox_information.Controls.Add(this.label_name);
            this.groupBox_information.Controls.Add(this.label_ID);
            this.groupBox_information.Controls.Add(this.label_ro_department);
            this.groupBox_information.Controls.Add(this.label_ro_name);
            this.groupBox_information.Controls.Add(this.label_ro_ID);
            this.groupBox_information.Location = new System.Drawing.Point(6, 6);
            this.groupBox_information.Name = "groupBox_information";
            this.groupBox_information.Size = new System.Drawing.Size(781, 182);
            this.groupBox_information.TabIndex = 0;
            this.groupBox_information.TabStop = false;
            this.groupBox_information.Text = "个人信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_confirm);
            this.groupBox2.Controls.Add(this.textBox_newPasswordConfirm);
            this.groupBox2.Controls.Add(this.textBox_newPassword);
            this.groupBox2.Controls.Add(this.textBox_oldPassword);
            this.groupBox2.Controls.Add(this.label_ro_repeatNewPassword);
            this.groupBox2.Controls.Add(this.label_ro_newPassword);
            this.groupBox2.Controls.Add(this.label_ro_oldPassword);
            this.groupBox2.Location = new System.Drawing.Point(6, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "更改密码";
            // 
            // label_ro_ID
            // 
            this.label_ro_ID.AutoSize = true;
            this.label_ro_ID.Location = new System.Drawing.Point(27, 35);
            this.label_ro_ID.Name = "label_ro_ID";
            this.label_ro_ID.Size = new System.Drawing.Size(41, 12);
            this.label_ro_ID.TabIndex = 0;
            this.label_ro_ID.Text = "学号：";
            // 
            // label_ro_name
            // 
            this.label_ro_name.AutoSize = true;
            this.label_ro_name.Location = new System.Drawing.Point(27, 74);
            this.label_ro_name.Name = "label_ro_name";
            this.label_ro_name.Size = new System.Drawing.Size(41, 12);
            this.label_ro_name.TabIndex = 1;
            this.label_ro_name.Text = "姓名：";
            // 
            // label_ro_department
            // 
            this.label_ro_department.AutoSize = true;
            this.label_ro_department.Location = new System.Drawing.Point(27, 114);
            this.label_ro_department.Name = "label_ro_department";
            this.label_ro_department.Size = new System.Drawing.Size(41, 12);
            this.label_ro_department.TabIndex = 2;
            this.label_ro_department.Text = "学院：";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(91, 35);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(35, 12);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "label";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(91, 74);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 12);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "label";
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Location = new System.Drawing.Point(91, 114);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(35, 12);
            this.label_department.TabIndex = 5;
            this.label_department.Text = "label";
            // 
            // label_ro_oldPassword
            // 
            this.label_ro_oldPassword.AutoSize = true;
            this.label_ro_oldPassword.Location = new System.Drawing.Point(51, 58);
            this.label_ro_oldPassword.Name = "label_ro_oldPassword";
            this.label_ro_oldPassword.Size = new System.Drawing.Size(53, 12);
            this.label_ro_oldPassword.TabIndex = 0;
            this.label_ro_oldPassword.Text = "旧密码：";
            // 
            // label_ro_newPassword
            // 
            this.label_ro_newPassword.AutoSize = true;
            this.label_ro_newPassword.Location = new System.Drawing.Point(51, 99);
            this.label_ro_newPassword.Name = "label_ro_newPassword";
            this.label_ro_newPassword.Size = new System.Drawing.Size(53, 12);
            this.label_ro_newPassword.TabIndex = 1;
            this.label_ro_newPassword.Text = "新密码：";
            // 
            // label_ro_repeatNewPassword
            // 
            this.label_ro_repeatNewPassword.AutoSize = true;
            this.label_ro_repeatNewPassword.Location = new System.Drawing.Point(27, 136);
            this.label_ro_repeatNewPassword.Name = "label_ro_repeatNewPassword";
            this.label_ro_repeatNewPassword.Size = new System.Drawing.Size(77, 12);
            this.label_ro_repeatNewPassword.TabIndex = 2;
            this.label_ro_repeatNewPassword.Text = "新密码确认：";
            // 
            // textBox_oldPassword
            // 
            this.textBox_oldPassword.Location = new System.Drawing.Point(110, 55);
            this.textBox_oldPassword.Name = "textBox_oldPassword";
            this.textBox_oldPassword.Size = new System.Drawing.Size(100, 21);
            this.textBox_oldPassword.TabIndex = 3;
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Location = new System.Drawing.Point(110, 96);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.Size = new System.Drawing.Size(100, 21);
            this.textBox_newPassword.TabIndex = 4;
            // 
            // textBox_newPasswordConfirm
            // 
            this.textBox_newPasswordConfirm.Location = new System.Drawing.Point(110, 133);
            this.textBox_newPasswordConfirm.Name = "textBox_newPasswordConfirm";
            this.textBox_newPasswordConfirm.Size = new System.Drawing.Size(100, 21);
            this.textBox_newPasswordConfirm.TabIndex = 5;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(51, 177);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "确认更改";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(135, 177);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 646);
            this.Controls.Add(this.tabControl);
            this.Name = "UserForm";
            this.Text = "学生选课系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_electiveManagement.ResumeLayout(false);
            this.tabPage_electiveManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_unselectedCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedCourses)).EndInit();
            this.tabPage_schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).EndInit();
            this.tabPage_information.ResumeLayout(false);
            this.groupBox_information.ResumeLayout(false);
            this.groupBox_information.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_electiveManagement;
        private System.Windows.Forms.TabPage tabPage_schedule;
        private System.Windows.Forms.DataGridView dataGridView_selectedCourses;
        private System.Windows.Forms.DataGridView dataGridView_unselectedCourses;
        private System.Windows.Forms.ComboBox comboBox_department;
        private System.Windows.Forms.Label label_courseDepartment;
        private System.Windows.Forms.TextBox textBox_courseName;
        private System.Windows.Forms.Label label_courseName;
        private System.Windows.Forms.Label label_courseID;
        private System.Windows.Forms.TextBox textBox_courseID;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_unselectedCourses;
        private System.Windows.Forms.Label label_SelectedCourses;
        private System.Windows.Forms.DataGridView dataGridView_schedule;
        private System.Windows.Forms.TabPage tabPage_information;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_detail;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_ro_repeatNewPassword;
        private System.Windows.Forms.Label label_ro_newPassword;
        private System.Windows.Forms.Label label_ro_oldPassword;
        private System.Windows.Forms.GroupBox groupBox_information;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_ro_department;
        private System.Windows.Forms.Label label_ro_name;
        private System.Windows.Forms.Label label_ro_ID;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.TextBox textBox_oldPassword;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_newPasswordConfirm;
        private System.Windows.Forms.Button button_reset;
    }
}