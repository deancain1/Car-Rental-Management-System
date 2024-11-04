namespace Carl_Rental_System.DisplayControl
{
    partial class UserDisplayCarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookNowBtn = new System.Windows.Forms.Button();
            this.TransmissionLbl = new System.Windows.Forms.Label();
            this.GasLbl = new System.Windows.Forms.Label();
            this.SeatsLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.BrandLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CarIdLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarImage = new System.Windows.Forms.PictureBox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1456, 685);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.QuantityLbl);
            this.panel1.Controls.Add(this.BookNowBtn);
            this.panel1.Controls.Add(this.TransmissionLbl);
            this.panel1.Controls.Add(this.GasLbl);
            this.panel1.Controls.Add(this.SeatsLbl);
            this.panel1.Controls.Add(this.PriceLbl);
            this.panel1.Controls.Add(this.ModelLbl);
            this.panel1.Controls.Add(this.BrandLbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CarIdLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CarImage);
            this.panel1.Location = new System.Drawing.Point(352, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(352, 41, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 432);
            this.panel1.TabIndex = 0;
            // 
            // BookNowBtn
            // 
            this.BookNowBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BookNowBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNowBtn.Location = new System.Drawing.Point(19, 300);
            this.BookNowBtn.Name = "BookNowBtn";
            this.BookNowBtn.Size = new System.Drawing.Size(249, 50);
            this.BookNowBtn.TabIndex = 16;
            this.BookNowBtn.Text = "Book Now";
            this.BookNowBtn.UseVisualStyleBackColor = false;
            this.BookNowBtn.Click += new System.EventHandler(this.BookNowBtn_Click);
            // 
            // TransmissionLbl
            // 
            this.TransmissionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransmissionLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmissionLbl.Location = new System.Drawing.Point(525, 300);
            this.TransmissionLbl.Name = "TransmissionLbl";
            this.TransmissionLbl.Size = new System.Drawing.Size(204, 42);
            this.TransmissionLbl.TabIndex = 15;
            this.TransmissionLbl.Text = "Transmission";
            // 
            // GasLbl
            // 
            this.GasLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GasLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasLbl.Location = new System.Drawing.Point(525, 224);
            this.GasLbl.Name = "GasLbl";
            this.GasLbl.Size = new System.Drawing.Size(204, 42);
            this.GasLbl.TabIndex = 14;
            this.GasLbl.Text = "Gas";
            // 
            // SeatsLbl
            // 
            this.SeatsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeatsLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsLbl.Location = new System.Drawing.Point(525, 155);
            this.SeatsLbl.Name = "SeatsLbl";
            this.SeatsLbl.Size = new System.Drawing.Size(204, 42);
            this.SeatsLbl.TabIndex = 13;
            this.SeatsLbl.Text = "Seats";
            // 
            // PriceLbl
            // 
            this.PriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(36, 160);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(200, 40);
            this.PriceLbl.TabIndex = 12;
            this.PriceLbl.Text = "Price";
            // 
            // ModelLbl
            // 
            this.ModelLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLbl.Location = new System.Drawing.Point(525, 85);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(204, 42);
            this.ModelLbl.TabIndex = 11;
            this.ModelLbl.Text = "CarName";
            // 
            // BrandLbl
            // 
            this.BrandLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.Location = new System.Drawing.Point(525, 18);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(204, 42);
            this.BrandLbl.TabIndex = 9;
            this.BrandLbl.Text = "Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Transmission:";
            // 
            // CarIdLbl
            // 
            this.CarIdLbl.AutoSize = true;
            this.CarIdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdLbl.Location = new System.Drawing.Point(4, 411);
            this.CarIdLbl.Name = "CarIdLbl";
            this.CarIdLbl.Size = new System.Drawing.Size(26, 19);
            this.CarIdLbl.TabIndex = 7;
            this.CarIdLbl.Text = "ID";
            this.CarIdLbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type of Car:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand:";
            // 
            // CarImage
            // 
            this.CarImage.Location = new System.Drawing.Point(19, 3);
            this.CarImage.Name = "CarImage";
            this.CarImage.Size = new System.Drawing.Size(260, 147);
            this.CarImage.TabIndex = 0;
            this.CarImage.TabStop = false;
            this.CarImage.Click += new System.EventHandler(this.CarImage_Click);
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(36, 242);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(200, 40);
            this.QuantityLbl.TabIndex = 17;
            this.QuantityLbl.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Availability";
            // 
            // UserDisplayCarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserDisplayCarControl";
            this.Size = new System.Drawing.Size(1456, 514);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BookNowBtn;
        private System.Windows.Forms.Label TransmissionLbl;
        private System.Windows.Forms.Label GasLbl;
        private System.Windows.Forms.Label SeatsLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label ModelLbl;
        private System.Windows.Forms.Label BrandLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CarIdLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CarImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label QuantityLbl;
    }
}
