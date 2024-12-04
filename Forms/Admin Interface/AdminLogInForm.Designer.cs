namespace Carl_Rental_System
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.exit_logIn = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ForgotPasswordBtn = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.ShowPasswordBtn = new System.Windows.Forms.Label();
            this.HidePasswordBtn = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_logIn
            // 
            resources.ApplyResources(this.exit_logIn, "exit_logIn");
            this.exit_logIn.ForeColor = System.Drawing.Color.DarkRed;
            this.exit_logIn.Name = "exit_logIn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Carl_Rental_System.Properties.Resources.Untitled_design__3_;
            this.panel3.Controls.Add(this.exit);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            resources.ApplyResources(this.exit, "exit");
            this.exit.BackColor = System.Drawing.Color.Bisque;
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Name = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.ForgotPasswordBtn);
            this.panel2.Controls.Add(this.LogInBtn);
            this.panel2.Controls.Add(this.ShowPasswordBtn);
            this.panel2.Controls.Add(this.HidePasswordBtn);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.UsernameTxt);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // ForgotPasswordBtn
            // 
            resources.ApplyResources(this.ForgotPasswordBtn, "ForgotPasswordBtn");
            this.ForgotPasswordBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Click += new System.EventHandler(this.ForgotPasswordBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.LogInBtn, "LogInBtn");
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.BackColor = System.Drawing.Color.White;
            this.ShowPasswordBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_eye_25;
            resources.ApplyResources(this.ShowPasswordBtn, "ShowPasswordBtn");
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Click += new System.EventHandler(this.ShowPasswordBtn_Click);
            // 
            // HidePasswordBtn
            // 
            this.HidePasswordBtn.BackColor = System.Drawing.Color.White;
            this.HidePasswordBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_hide_25__1_;
            resources.ApplyResources(this.HidePasswordBtn, "HidePasswordBtn");
            this.HidePasswordBtn.Name = "HidePasswordBtn";
            this.HidePasswordBtn.Click += new System.EventHandler(this.HidePasswordBtn_Click);
            // 
            // PasswordTxt
            // 
            resources.ApplyResources(this.PasswordTxt, "PasswordTxt");
            this.PasswordTxt.Name = "PasswordTxt";
            // 
            // UsernameTxt
            // 
            resources.ApplyResources(this.UsernameTxt, "UsernameTxt");
            this.UsernameTxt.Name = "UsernameTxt";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BackBtn);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BackBtn, "BackBtn");
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BackBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_back_15;
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // kryptonLabel1
            // 
            resources.ApplyResources(this.kryptonLabel1, "kryptonLabel1");
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.TabStop = false;
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_secure_35;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Carl_Rental_System.Properties.Resources.icons8_user_35;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // AdminLoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_logIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label ShowPasswordBtn;
        private System.Windows.Forms.Label HidePasswordBtn;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label ForgotPasswordBtn;
    }
}

