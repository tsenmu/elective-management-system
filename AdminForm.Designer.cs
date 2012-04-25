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
            this.tabPage_courseManagement = new System.Windows.Forms.TabPage();
            this.tabPage_systemManagement = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
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
            this.tabPage_userManagement.Location = new System.Drawing.Point(4, 21);
            this.tabPage_userManagement.Name = "tabPage_userManagement";
            this.tabPage_userManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_userManagement.Size = new System.Drawing.Size(750, 542);
            this.tabPage_userManagement.TabIndex = 0;
            this.tabPage_userManagement.Text = "用户管理";
            this.tabPage_userManagement.UseVisualStyleBackColor = true;
            // 
            // tabPage_courseManagement
            // 
            this.tabPage_courseManagement.Location = new System.Drawing.Point(4, 21);
            this.tabPage_courseManagement.Name = "tabPage_courseManagement";
            this.tabPage_courseManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_courseManagement.Size = new System.Drawing.Size(750, 542);
            this.tabPage_courseManagement.TabIndex = 1;
            this.tabPage_courseManagement.Text = "课程管理";
            this.tabPage_courseManagement.UseVisualStyleBackColor = true;
            // 
            // tabPage_systemManagement
            // 
            this.tabPage_systemManagement.Location = new System.Drawing.Point(4, 21);
            this.tabPage_systemManagement.Name = "tabPage_systemManagement";
            this.tabPage_systemManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_systemManagement.Size = new System.Drawing.Size(750, 542);
            this.tabPage_systemManagement.TabIndex = 2;
            this.tabPage_systemManagement.Text = "系统管理";
            this.tabPage_systemManagement.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 591);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "学生选课系统（管理员模式）";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_userManagement;
        private System.Windows.Forms.TabPage tabPage_courseManagement;
        private System.Windows.Forms.TabPage tabPage_systemManagement;
    }
}