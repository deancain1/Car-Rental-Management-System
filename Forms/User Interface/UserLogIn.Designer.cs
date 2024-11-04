namespace Carl_Rental_System.Forms.User_Interface
{
    partial class UserLogIn
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminloginBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register_here_btn = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.UserNameText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_logIn
            // 
            this.exit_logIn.AutoSize = true;
            this.exit_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.exit_logIn.ForeColor = System.Drawing.Color.DarkRed;
            this.exit_logIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_logIn.Location = new System.Drawing.Point(1274, 6);
            this.exit_logIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exit_logIn.Name = "exit_logIn";
            this.exit_logIn.Size = new System.Drawing.Size(18, 17);
            this.exit_logIn.TabIndex = 12;
            this.exit_logIn.Text = "X";
            this.exit_logIn.Click += new System.EventHandler(this.exit_logIn_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 687);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.adminloginBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Register_here_btn);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.kryptonCheckBox1);
            this.panel2.Controls.Add(this.LogInBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PasswordText);
            this.panel2.Controls.Add(this.UserNameText);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 686);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // adminloginBtn
            // 
            this.adminloginBtn.AutoSize = true;
            this.adminloginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminloginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.adminloginBtn.Location = new System.Drawing.Point(120, 631);
            this.adminloginBtn.Name = "adminloginBtn";
            this.adminloginBtn.Size = new System.Drawing.Size(117, 24);
            this.adminloginBtn.TabIndex = 9;
            this.adminloginBtn.Text = "Admin LogIn";
            this.adminloginBtn.Click += new System.EventHandler(this.adminloginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(40, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Don\'t have an account yet?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Register_here_btn
            // 
            this.Register_here_btn.AutoSize = true;
            this.Register_here_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_here_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Register_here_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Register_here_btn.Location = new System.Drawing.Point(232, 602);
            this.Register_here_btn.Name = "Register_here_btn";
            this.Register_here_btn.Size = new System.Drawing.Size(91, 16);
            this.Register_here_btn.TabIndex = 7;
            this.Register_here_btn.Text = "Register Here";
            this.Register_here_btn.Click += new System.EventHandler(this.Register_here_btn_Click_1);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.TabStop = false;
            this.kryptonLabel1.Values.Text = null;
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(244, 370);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(108, 20);
            this.kryptonCheckBox1.TabIndex = 6;
            this.kryptonCheckBox1.Values.Text = "Show Password";
            this.kryptonCheckBox1.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Bisque;
            this.LogInBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogInBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogInBtn.Location = new System.Drawing.Point(87, 413);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(236, 44);
            this.LogInBtn.TabIndex = 5;
            this.LogInBtn.Text = "LOGIN";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(119, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "     LOGIN\r\n   ACCOUNT\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(74, 330);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(278, 37);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // UserNameText
            // 
            this.UserNameText.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.UserNameText.Location = new System.Drawing.Point(74, 274);
            this.UserNameText.Multiline = true;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(278, 37);
            this.UserNameText.TabIndex = 0;
            this.UserNameText.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Carl_Rental_System.Properties.Resources.Untitled_design__3_;
            this.panel3.Controls.Add(this.exit);
            this.panel3.Location = new System.Drawing.Point(398, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 680);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_password_39;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(33, 330);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_user_39;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(34, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.exit_logIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogIn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_logIn;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Register_here_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PasswordText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox UserNameText;
        private System.Windows.Forms.Label adminloginBtn;
    }
}