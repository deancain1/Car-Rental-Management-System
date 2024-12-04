namespace Carl_Rental_System.Forms.Admin_Interface
{
    partial class ForgotPasswordAdmin
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
            this.exit_logIn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnswerTxt = new System.Windows.Forms.TextBox();
            this.SecurityQuestionCB = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.ShowPasswordBtn = new System.Windows.Forms.Label();
            this.HidePasswordBtn = new System.Windows.Forms.Label();
            this.NewPasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_logIn
            // 
            this.exit_logIn.AutoSize = true;
            this.exit_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.exit_logIn.ForeColor = System.Drawing.Color.DarkRed;
            this.exit_logIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_logIn.Location = new System.Drawing.Point(1164, 6);
            this.exit_logIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exit_logIn.Name = "exit_logIn";
            this.exit_logIn.Size = new System.Drawing.Size(18, 17);
            this.exit_logIn.TabIndex = 16;
            this.exit_logIn.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Security Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Username";
            // 
            // AnswerTxt
            // 
            this.AnswerTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTxt.Location = new System.Drawing.Point(42, 351);
            this.AnswerTxt.Name = "AnswerTxt";
            this.AnswerTxt.Size = new System.Drawing.Size(310, 34);
            this.AnswerTxt.TabIndex = 43;
            // 
            // SecurityQuestionCB
            // 
            this.SecurityQuestionCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityQuestionCB.FormattingEnabled = true;
            this.SecurityQuestionCB.Items.AddRange(new object[] {
            "What is the first name of your bestfriend in high school?",
            "What was the name of your first pet?",
            "What was the first film you saw in theater?",
            "What is your favorite color?",
            "What is your favorite food?"});
            this.SecurityQuestionCB.Location = new System.Drawing.Point(42, 283);
            this.SecurityQuestionCB.Name = "SecurityQuestionCB";
            this.SecurityQuestionCB.Size = new System.Drawing.Size(310, 29);
            this.SecurityQuestionCB.TabIndex = 42;
            this.SecurityQuestionCB.Text = "Please Select";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BackBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_back_15;
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackBtn.Location = new System.Drawing.Point(-22, -12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BackBtn.Size = new System.Drawing.Size(162, 71);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BackBtn);
            this.panel4.Location = new System.Drawing.Point(16, 615);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 41);
            this.panel4.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Carl_Rental_System.Properties.Resources.Untitled_design__3_;
            this.panel3.Controls.Add(this.exit);
            this.panel3.Location = new System.Drawing.Point(398, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 680);
            this.panel3.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Bisque;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(721, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 20);
            this.exit.TabIndex = 9;
            this.exit.Text = "X";
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.BackColor = System.Drawing.Color.White;
            this.ShowPasswordBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_eye_25;
            this.ShowPasswordBtn.Location = new System.Drawing.Point(314, 428);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(34, 24);
            this.ShowPasswordBtn.TabIndex = 39;
            this.ShowPasswordBtn.Click += new System.EventHandler(this.ShowPasswordBtn_Click);
            // 
            // HidePasswordBtn
            // 
            this.HidePasswordBtn.BackColor = System.Drawing.Color.White;
            this.HidePasswordBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_hide_25__1_;
            this.HidePasswordBtn.Location = new System.Drawing.Point(314, 428);
            this.HidePasswordBtn.Name = "HidePasswordBtn";
            this.HidePasswordBtn.Size = new System.Drawing.Size(34, 24);
            this.HidePasswordBtn.TabIndex = 40;
            this.HidePasswordBtn.Click += new System.EventHandler(this.HidePasswordBtn_Click);
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTxt.Location = new System.Drawing.Point(44, 423);
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.PasswordChar = '*';
            this.NewPasswordTxt.Size = new System.Drawing.Size(308, 34);
            this.NewPasswordTxt.TabIndex = 11;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(42, 211);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(310, 34);
            this.UsernameTxt.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.TabStop = false;
            this.kryptonLabel1.Values.Text = null;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ChangePasswordBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangePasswordBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChangePasswordBtn.Location = new System.Drawing.Point(79, 490);
            this.ChangePasswordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(236, 44);
            this.ChangePasswordBtn.TabIndex = 5;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = false;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(86, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 687);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AnswerTxt);
            this.panel2.Controls.Add(this.SecurityQuestionCB);
            this.panel2.Controls.Add(this.ShowPasswordBtn);
            this.panel2.Controls.Add(this.HidePasswordBtn);
            this.panel2.Controls.Add(this.NewPasswordTxt);
            this.panel2.Controls.Add(this.UsernameTxt);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.ChangePasswordBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 686);
            this.panel2.TabIndex = 0;
            // 
            // ForgotPasswordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.exit_logIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordAdmin";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_logIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnswerTxt;
        private System.Windows.Forms.ComboBox SecurityQuestionCB;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label ShowPasswordBtn;
        private System.Windows.Forms.Label HidePasswordBtn;
        private System.Windows.Forms.TextBox NewPasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}