namespace Carl_Rental_System.Forms
{
    partial class RegisterAcc
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ShowPasswordBtn = new System.Windows.Forms.Label();
            this.HidePasswordBtn = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.LocationTxt = new System.Windows.Forms.TextBox();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.RoleTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.login_here_btn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 685);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.ShowPasswordBtn);
            this.panel3.Controls.Add(this.HidePasswordBtn);
            this.panel3.Controls.Add(this.PasswordTxt);
            this.panel3.Controls.Add(this.UsernameTxt);
            this.panel3.Controls.Add(this.EmailTxt);
            this.panel3.Controls.Add(this.PhoneNumberTxt);
            this.panel3.Controls.Add(this.AgeTxt);
            this.panel3.Controls.Add(this.LocationTxt);
            this.panel3.Controls.Add(this.FullNameTxt);
            this.panel3.Controls.Add(this.RoleTxt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.login_here_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.signUp_btn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(751, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 683);
            this.panel3.TabIndex = 0;
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.BackColor = System.Drawing.Color.White;
            this.ShowPasswordBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_eye_25;
            this.ShowPasswordBtn.Location = new System.Drawing.Point(304, 509);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(31, 24);
            this.ShowPasswordBtn.TabIndex = 41;
            this.ShowPasswordBtn.Click += new System.EventHandler(this.ShowPasswordBtn_Click_1);
            // 
            // HidePasswordBtn
            // 
            this.HidePasswordBtn.BackColor = System.Drawing.Color.White;
            this.HidePasswordBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_hide_25__1_;
            this.HidePasswordBtn.Location = new System.Drawing.Point(304, 509);
            this.HidePasswordBtn.Name = "HidePasswordBtn";
            this.HidePasswordBtn.Size = new System.Drawing.Size(31, 24);
            this.HidePasswordBtn.TabIndex = 43;
            this.HidePasswordBtn.Click += new System.EventHandler(this.HidePasswordBtn_Click_1);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(64, 504);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(276, 34);
            this.PasswordTxt.TabIndex = 34;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(64, 439);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(276, 34);
            this.UsernameTxt.TabIndex = 33;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(64, 378);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(276, 34);
            this.EmailTxt.TabIndex = 32;
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTxt.Location = new System.Drawing.Point(64, 311);
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(276, 34);
            this.PhoneNumberTxt.TabIndex = 31;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTxt.Location = new System.Drawing.Point(64, 176);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(276, 34);
            this.AgeTxt.TabIndex = 30;
            // 
            // LocationTxt
            // 
            this.LocationTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTxt.Location = new System.Drawing.Point(64, 243);
            this.LocationTxt.Name = "LocationTxt";
            this.LocationTxt.Size = new System.Drawing.Size(276, 34);
            this.LocationTxt.TabIndex = 29;
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTxt.Location = new System.Drawing.Point(64, 108);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(276, 34);
            this.FullNameTxt.TabIndex = 28;
            // 
            // RoleTxt
            // 
            this.RoleTxt.Location = new System.Drawing.Point(64, 544);
            this.RoleTxt.Multiline = true;
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.ReadOnly = true;
            this.RoleTxt.Size = new System.Drawing.Size(87, 24);
            this.RoleTxt.TabIndex = 27;
            this.RoleTxt.Text = "Customer";
            this.RoleTxt.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(60, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "PhoneNumber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(60, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(60, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(60, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(57, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(60, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Full Name";
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Bisque;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(369, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 20);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login_here_btn
            // 
            this.login_here_btn.AutoSize = true;
            this.login_here_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_here_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.login_here_btn.Location = new System.Drawing.Point(247, 641);
            this.login_here_btn.Name = "login_here_btn";
            this.login_here_btn.Size = new System.Drawing.Size(90, 20);
            this.login_here_btn.TabIndex = 10;
            this.login_here_btn.Text = "Login Here";
            this.login_here_btn.Click += new System.EventHandler(this.login_here_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(48, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Already have an account?";
            // 
            // signUp_btn
            // 
            this.signUp_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.signUp_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.signUp_btn.Location = new System.Drawing.Point(80, 585);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(236, 41);
            this.signUp_btn.TabIndex = 7;
            this.signUp_btn.Text = "SIGNUP";
            this.signUp_btn.UseVisualStyleBackColor = false;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER REGISTER \r\n      ACCOUNT";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Carl_Rental_System.Properties.Resources.Untitled_design__4_;
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 682);
            this.panel2.TabIndex = 0;
            // 
            // RegisterAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterAcc";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PhoneNumberTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox LocationTxt;
        private System.Windows.Forms.TextBox FullNameTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox RoleTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label login_here_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShowPasswordBtn;
        private System.Windows.Forms.Label HidePasswordBtn;
    }
}