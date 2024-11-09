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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDisplayCarControl));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.AddQuantity = new System.Windows.Forms.Button();
            this.SubQuantity = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AvailabilityLbl = new System.Windows.Forms.Label();
            this.BookNowBtn = new System.Windows.Forms.Button();
            this.TransmissionLbl = new System.Windows.Forms.Label();
            this.GasLbl = new System.Windows.Forms.Label();
            this.SeatsLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.BrandLbl = new System.Windows.Forms.Label();
            this.CarIdLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1540, 508);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.QuantityLbl);
            this.panel1.Controls.Add(this.AddQuantity);
            this.panel1.Controls.Add(this.SubQuantity);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.AvailabilityLbl);
            this.panel1.Controls.Add(this.BookNowBtn);
            this.panel1.Controls.Add(this.TransmissionLbl);
            this.panel1.Controls.Add(this.GasLbl);
            this.panel1.Controls.Add(this.SeatsLbl);
            this.panel1.Controls.Add(this.PriceLbl);
            this.panel1.Controls.Add(this.ModelLbl);
            this.panel1.Controls.Add(this.BrandLbl);
            this.panel1.Controls.Add(this.CarIdLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CarImage);
            this.panel1.Location = new System.Drawing.Point(310, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(310, 41, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 432);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(118, 212);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(34, 32);
            this.QuantityLbl.TabIndex = 29;
            this.QuantityLbl.Text = "1";
            this.QuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuantity
            // 
            this.AddQuantity.Image = global::Carl_Rental_System.Properties.Resources.icons8_plus_math_40;
            this.AddQuantity.Location = new System.Drawing.Point(156, 214);
            this.AddQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Size = new System.Drawing.Size(32, 28);
            this.AddQuantity.TabIndex = 28;
            this.AddQuantity.UseVisualStyleBackColor = true;
            this.AddQuantity.Click += new System.EventHandler(this.AddQuantity_Click);
            // 
            // SubQuantity
            // 
            this.SubQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubQuantity.Image = global::Carl_Rental_System.Properties.Resources.icons8_subtract_40;
            this.SubQuantity.Location = new System.Drawing.Point(82, 214);
            this.SubQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.SubQuantity.Name = "SubQuantity";
            this.SubQuantity.Size = new System.Drawing.Size(32, 28);
            this.SubQuantity.TabIndex = 27;
            this.SubQuantity.UseVisualStyleBackColor = true;
            this.SubQuantity.Click += new System.EventHandler(this.SubQuantity_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(608, 154);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(312, 77);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantity";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(608, 77);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // AvailabilityLbl
            // 
            this.AvailabilityLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvailabilityLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityLbl.Location = new System.Drawing.Point(362, 156);
            this.AvailabilityLbl.Name = "AvailabilityLbl";
            this.AvailabilityLbl.Size = new System.Drawing.Size(200, 40);
            this.AvailabilityLbl.TabIndex = 17;
            this.AvailabilityLbl.Text = "Availability";
            // 
            // BookNowBtn
            // 
            this.BookNowBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BookNowBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNowBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BookNowBtn.Location = new System.Drawing.Point(7, 258);
            this.BookNowBtn.Name = "BookNowBtn";
            this.BookNowBtn.Size = new System.Drawing.Size(256, 53);
            this.BookNowBtn.TabIndex = 16;
            this.BookNowBtn.Text = "Book Now";
            this.BookNowBtn.UseVisualStyleBackColor = false;
            this.BookNowBtn.Click += new System.EventHandler(this.BookNowBtn_Click);
            // 
            // TransmissionLbl
            // 
            this.TransmissionLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransmissionLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmissionLbl.Location = new System.Drawing.Point(655, 154);
            this.TransmissionLbl.Name = "TransmissionLbl";
            this.TransmissionLbl.Size = new System.Drawing.Size(203, 41);
            this.TransmissionLbl.TabIndex = 15;
            this.TransmissionLbl.Text = "Transmission";
            // 
            // GasLbl
            // 
            this.GasLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GasLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasLbl.Location = new System.Drawing.Point(655, 77);
            this.GasLbl.Name = "GasLbl";
            this.GasLbl.Size = new System.Drawing.Size(203, 41);
            this.GasLbl.TabIndex = 14;
            this.GasLbl.Text = "Gas";
            // 
            // SeatsLbl
            // 
            this.SeatsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeatsLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsLbl.Location = new System.Drawing.Point(358, 77);
            this.SeatsLbl.Name = "SeatsLbl";
            this.SeatsLbl.Size = new System.Drawing.Size(203, 41);
            this.SeatsLbl.TabIndex = 13;
            this.SeatsLbl.Text = "Seats";
            // 
            // PriceLbl
            // 
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(8, 172);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(200, 40);
            this.PriceLbl.TabIndex = 12;
            this.PriceLbl.Text = "Price";
            // 
            // ModelLbl
            // 
            this.ModelLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModelLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLbl.Location = new System.Drawing.Point(655, 9);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(203, 41);
            this.ModelLbl.TabIndex = 11;
            this.ModelLbl.Text = "CarName";
            // 
            // BrandLbl
            // 
            this.BrandLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BrandLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.Location = new System.Drawing.Point(358, 7);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(203, 41);
            this.BrandLbl.TabIndex = 9;
            this.BrandLbl.Text = "Brand";
            // 
            // CarIdLbl
            // 
            this.CarIdLbl.AutoSize = true;
            this.CarIdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdLbl.Location = new System.Drawing.Point(3, 384);
            this.CarIdLbl.Name = "CarIdLbl";
            this.CarIdLbl.Size = new System.Drawing.Size(26, 19);
            this.CarIdLbl.TabIndex = 7;
            this.CarIdLbl.Text = "ID";
            this.CarIdLbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand:";
            // 
            // CarImage
            // 
            this.CarImage.Location = new System.Drawing.Point(8, 15);
            this.CarImage.Name = "CarImage";
            this.CarImage.Size = new System.Drawing.Size(260, 147);
            this.CarImage.TabIndex = 0;
            this.CarImage.TabStop = false;
            // 
            // UserDisplayCarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserDisplayCarControl";
            this.Size = new System.Drawing.Size(1540, 508);
            this.Load += new System.EventHandler(this.UserDisplayCarControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label CarIdLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CarImage;
        private System.Windows.Forms.Label AvailabilityLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button AddQuantity;
        private System.Windows.Forms.Button SubQuantity;
        private System.Windows.Forms.Label QuantityLbl;
    }
}
