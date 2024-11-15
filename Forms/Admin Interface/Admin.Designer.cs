namespace Carl_Rental_System.Forms.Admin_Interface
{
    partial class Admin
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AddAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.uploaCarBtn = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(233, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1307, 805);
            this.mainPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sidePanel.Controls.Add(this.panel3);
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.panel2);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 40);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(233, 805);
            this.sidePanel.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LogoutBtn);
            this.panel3.Location = new System.Drawing.Point(3, 617);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 54);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AddAdmin);
            this.panel4.Location = new System.Drawing.Point(0, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 55);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Location = new System.Drawing.Point(3, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 58);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uploaCarBtn);
            this.panel2.Location = new System.Drawing.Point(-3, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 55);
            this.panel2.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1540, 40);
            this.headerPanel.TabIndex = 10;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogoutBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_back_15__1_;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoutBtn.Location = new System.Drawing.Point(-32, -9);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(162, 71);
            this.LogoutBtn.TabIndex = 11;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AddAdmin
            // 
            this.AddAdmin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AddAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.AddAdmin.Image = global::Carl_Rental_System.Properties.Resources.icons8_add_administrator_25__4_;
            this.AddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAdmin.Location = new System.Drawing.Point(-4, -20);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(291, 89);
            this.AddAdmin.TabIndex = 4;
            this.AddAdmin.Text = "Add Admin";
            this.AddAdmin.UseVisualStyleBackColor = false;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
            this.AddAdmin.MouseLeave += new System.EventHandler(this.AddAdmin_MouseLeave);
            this.AddAdmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddAdmin_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carl_Rental_System.Properties.Resources.icons8_people_100;
            this.pictureBox1.Location = new System.Drawing.Point(63, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboardBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_traffic_jam_25;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(-4, -16);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(291, 89);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Available Cars";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            this.dashboardBtn.MouseLeave += new System.EventHandler(this.dashboardBtn_MouseLeave);
            this.dashboardBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dashboardBtn_MouseMove);
            // 
            // uploaCarBtn
            // 
            this.uploaCarBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.uploaCarBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploaCarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.uploaCarBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_car_25__1_;
            this.uploaCarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploaCarBtn.Location = new System.Drawing.Point(-1, -20);
            this.uploaCarBtn.Name = "uploaCarBtn";
            this.uploaCarBtn.Size = new System.Drawing.Size(291, 89);
            this.uploaCarBtn.TabIndex = 0;
            this.uploaCarBtn.Text = "Upload Car";
            this.uploaCarBtn.UseVisualStyleBackColor = false;
            this.uploaCarBtn.Click += new System.EventHandler(this.uploaCarBtn_Click);
            this.uploaCarBtn.MouseLeave += new System.EventHandler(this.uploaCarBtn_MouseLeave);
            this.uploaCarBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uploaCarBtn_MouseMove);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.sidePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uploaCarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddAdmin;
    }
}