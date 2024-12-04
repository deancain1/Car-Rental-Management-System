namespace Carl_Rental_System.Forms.User_Interface
{
    partial class NavigationBarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BookingBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 845);
            this.panel1.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 55);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1540, 790);
            this.mainPanel.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.Sienna;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1540, 55);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LogoutBtn);
            this.panel3.Location = new System.Drawing.Point(569, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 50);
            this.panel3.TabIndex = 3;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoutBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_logout_25__1_;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(-28, -14);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(179, 77);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            this.LogoutBtn.MouseLeave += new System.EventHandler(this.LogoutBtn_MouseLeave);
            this.LogoutBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoutBtn_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1000, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(528, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO OUR CAR RENTAL ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BookingBtn);
            this.panel7.Location = new System.Drawing.Point(290, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(124, 50);
            this.panel7.TabIndex = 5;
            // 
            // BookingBtn
            // 
            this.BookingBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BookingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookingBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_cars_25;
            this.BookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookingBtn.Location = new System.Drawing.Point(-24, -15);
            this.BookingBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BookingBtn.Name = "BookingBtn";
            this.BookingBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BookingBtn.Size = new System.Drawing.Size(179, 77);
            this.BookingBtn.TabIndex = 4;
            this.BookingBtn.Text = "Booking";
            this.BookingBtn.UseVisualStyleBackColor = false;
            this.BookingBtn.Click += new System.EventHandler(this.BookingBtn_Click);
            this.BookingBtn.MouseLeave += new System.EventHandler(this.BookingBtn_MouseLeave);
            this.BookingBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookingBtn_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 50);
            this.panel2.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_home_25__1_;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(-25, -15);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(179, 77);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            this.HomeBtn.MouseLeave += new System.EventHandler(this.HomeBtn_MouseLeave);
            this.HomeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeBtn_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ProfileBtn);
            this.panel4.Location = new System.Drawing.Point(430, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 50);
            this.panel4.TabIndex = 3;
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfileBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_test_account_25;
            this.ProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.Location = new System.Drawing.Point(-26, -13);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ProfileBtn.Size = new System.Drawing.Size(179, 77);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            this.ProfileBtn.MouseLeave += new System.EventHandler(this.ProfileBtn_MouseLeave);
            this.ProfileBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProfileBtn_MouseMove);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CarBtn);
            this.panel6.Location = new System.Drawing.Point(151, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(124, 50);
            this.panel6.TabIndex = 4;
            // 
            // CarBtn
            // 
            this.CarBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CarBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_cars_25;
            this.CarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CarBtn.Location = new System.Drawing.Point(-26, -13);
            this.CarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CarBtn.Name = "CarBtn";
            this.CarBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.CarBtn.Size = new System.Drawing.Size(179, 77);
            this.CarBtn.TabIndex = 3;
            this.CarBtn.Text = "Cars";
            this.CarBtn.UseVisualStyleBackColor = false;
            this.CarBtn.Click += new System.EventHandler(this.CarBtn_Click);
            this.CarBtn.MouseLeave += new System.EventHandler(this.CarBtn_MouseLeave);
            this.CarBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CarBtn_MouseMove);
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.panel1);
            this.Name = "UserInterfaceForm";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button CarBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BookingBtn;
    }
}