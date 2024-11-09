namespace Carl_Rental_System.Forms.User_Interface
{
    partial class UserHomeForm
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
            this.RentNowBtn = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::Carl_Rental_System.Properties.Resources.webinar_5;
            this.mainPanel.Controls.Add(this.RentNowBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1540, 790);
            this.mainPanel.TabIndex = 1;
            // 
            // RentNowBtn
            // 
            this.RentNowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RentNowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentNowBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RentNowBtn.Location = new System.Drawing.Point(55, 474);
            this.RentNowBtn.Name = "RentNowBtn";
            this.RentNowBtn.Size = new System.Drawing.Size(269, 51);
            this.RentNowBtn.TabIndex = 0;
            this.RentNowBtn.Text = "RENT NOW";
            this.RentNowBtn.Click += new System.EventHandler(this.RentNowBtn_Click);
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 790);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserHomeForm";
            this.Text = "UserHomeForm";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RentNowBtn;
        private System.Windows.Forms.Panel mainPanel;
    }
}