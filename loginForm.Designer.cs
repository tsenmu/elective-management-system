namespace ElectiveManagementSystem
{
    partial class LoginForm
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
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(202, 69);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(83, 16);
            this.checkBoxIsAdmin.TabIndex = 0;
            this.checkBoxIsAdmin.Text = "管理员登录";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            this.checkBoxIsAdmin.CheckedChanged += new System.EventHandler(this.checkBox_isAdmin_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(121, 100);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(78, 27);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(100, 21);
            this.textBox_user.TabIndex = 2;
            this.textBox_user.TextChanged += new System.EventHandler(this.textBox_user_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(78, 58);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 21);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(35, 31);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(29, 12);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "账号";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(35, 62);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(29, 12);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "密码";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(202, 100);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "关闭";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(290, 142);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.MaximumSize = new System.Drawing.Size(298, 176);
            this.MinimumSize = new System.Drawing.Size(298, 176);
            this.Name = "LoginForm";
            this.Text = "学生选课系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.userLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_cancel;
    }
}