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
            this.exit = new System.Windows.Forms.Label();
            this.login_here_btn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.password_signUp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.username_signUp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.email_signUp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.login_here_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.kryptonCheckBox1);
            this.panel3.Controls.Add(this.signUp_btn);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.password_signUp);
            this.panel3.Controls.Add(this.username_signUp);
            this.panel3.Controls.Add(this.email_signUp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(751, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 683);
            this.panel3.TabIndex = 0;
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
            this.login_here_btn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_here_btn.Location = new System.Drawing.Point(235, 549);
            this.login_here_btn.Name = "login_here_btn";
            this.login_here_btn.Size = new System.Drawing.Size(79, 17);
            this.login_here_btn.TabIndex = 10;
            this.login_here_btn.Text = "Login Here";
            this.login_here_btn.Click += new System.EventHandler(this.login_here_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Already have an account?";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(47, 383);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(108, 20);
            this.kryptonCheckBox1.TabIndex = 8;
            this.kryptonCheckBox1.Values.Text = "Show Password";
            // 
            // signUp_btn
            // 
            this.signUp_btn.BackColor = System.Drawing.Color.Bisque;
            this.signUp_btn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_btn.Location = new System.Drawing.Point(69, 438);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(236, 41);
            this.signUp_btn.TabIndex = 7;
            this.signUp_btn.Text = "SIGNUP";
            this.signUp_btn.UseVisualStyleBackColor = false;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click_1);
            // 
            // password_signUp
            // 
            this.password_signUp.Location = new System.Drawing.Point(47, 343);
            this.password_signUp.Multiline = true;
            this.password_signUp.Name = "password_signUp";
            this.password_signUp.Size = new System.Drawing.Size(273, 34);
            this.password_signUp.TabIndex = 3;
            // 
            // username_signUp
            // 
            this.username_signUp.Location = new System.Drawing.Point(47, 289);
            this.username_signUp.Multiline = true;
            this.username_signUp.Name = "username_signUp";
            this.username_signUp.Size = new System.Drawing.Size(273, 34);
            this.username_signUp.TabIndex = 2;
            // 
            // email_signUp
            // 
            this.email_signUp.AccessibleName = "";
            this.email_signUp.Location = new System.Drawing.Point(47, 234);
            this.email_signUp.Multiline = true;
            this.email_signUp.Name = "email_signUp";
            this.email_signUp.Size = new System.Drawing.Size(273, 34);
            this.email_signUp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 50);
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
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_password_39;
            this.pictureBox3.Location = new System.Drawing.Point(338, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 34);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_user_39;
            this.pictureBox2.Location = new System.Drawing.Point(338, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_email_39;
            this.pictureBox1.Location = new System.Drawing.Point(338, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox password_signUp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username_signUp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_signUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label login_here_btn;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.Label exit;
    }
}