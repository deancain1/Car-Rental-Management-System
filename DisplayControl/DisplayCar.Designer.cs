namespace Carl_Rental_System.DisplayControl
{
    partial class DisplayCar
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
            this.flpCar = new System.Windows.Forms.FlowLayoutPanel();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.StockLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DailyRateLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.AddQuantity = new System.Windows.Forms.Button();
            this.SubQuantity = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CarIdLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rentCarBTn = new System.Windows.Forms.Button();
            this.CarImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.BrandLbl = new System.Windows.Forms.Label();
            this.flpCar.SuspendLayout();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flpCar
            // 
            this.flpCar.AutoScroll = true;
            this.flpCar.Controls.Add(this.CardPanel);
            this.flpCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCar.Location = new System.Drawing.Point(0, 0);
            this.flpCar.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flpCar.Name = "flpCar";
            this.flpCar.Size = new System.Drawing.Size(415, 340);
            this.flpCar.TabIndex = 0;
            // 
            // CardPanel
            // 
            this.CardPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.label7);
            this.CardPanel.Controls.Add(this.StockLbl);
            this.CardPanel.Controls.Add(this.label4);
            this.CardPanel.Controls.Add(this.DailyRateLbl);
            this.CardPanel.Controls.Add(this.QuantityLbl);
            this.CardPanel.Controls.Add(this.AddQuantity);
            this.CardPanel.Controls.Add(this.SubQuantity);
            this.CardPanel.Controls.Add(this.label5);
            this.CardPanel.Controls.Add(this.label3);
            this.CardPanel.Controls.Add(this.CarIdLbl);
            this.CardPanel.Controls.Add(this.label2);
            this.CardPanel.Controls.Add(this.rentCarBTn);
            this.CardPanel.Controls.Add(this.CarImage);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Controls.Add(this.PriceLbl);
            this.CardPanel.Controls.Add(this.ModelLbl);
            this.CardPanel.Controls.Add(this.BrandLbl);
            this.CardPanel.Location = new System.Drawing.Point(10, 3);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.CardPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardPanel.Size = new System.Drawing.Size(396, 331);
            this.CardPanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Stock:";
            // 
            // StockLbl
            // 
            this.StockLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLbl.Location = new System.Drawing.Point(78, 287);
            this.StockLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockLbl.Name = "StockLbl";
            this.StockLbl.Size = new System.Drawing.Size(87, 37);
            this.StockLbl.TabIndex = 36;
            this.StockLbl.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Daily Rate:";
            // 
            // DailyRateLbl
            // 
            this.DailyRateLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DailyRateLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRateLbl.Location = new System.Drawing.Point(266, 158);
            this.DailyRateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailyRateLbl.Name = "DailyRateLbl";
            this.DailyRateLbl.Size = new System.Drawing.Size(87, 37);
            this.DailyRateLbl.TabIndex = 34;
            this.DailyRateLbl.Text = "label1";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(277, 230);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(34, 32);
            this.QuantityLbl.TabIndex = 33;
            this.QuantityLbl.Text = "1";
            this.QuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuantity
            // 
            this.AddQuantity.Image = global::Carl_Rental_System.Properties.Resources.icons8_plus_math_40;
            this.AddQuantity.Location = new System.Drawing.Point(315, 232);
            this.AddQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Size = new System.Drawing.Size(32, 28);
            this.AddQuantity.TabIndex = 32;
            this.AddQuantity.UseVisualStyleBackColor = true;
            this.AddQuantity.Click += new System.EventHandler(this.AddQuantity_Click);
            // 
            // SubQuantity
            // 
            this.SubQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubQuantity.Image = global::Carl_Rental_System.Properties.Resources.icons8_subtract_40;
            this.SubQuantity.Location = new System.Drawing.Point(241, 232);
            this.SubQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.SubQuantity.Name = "SubQuantity";
            this.SubQuantity.Size = new System.Drawing.Size(32, 28);
            this.SubQuantity.TabIndex = 31;
            this.SubQuantity.UseVisualStyleBackColor = true;
            this.SubQuantity.Click += new System.EventHandler(this.SubQuantity_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model:";
            // 
            // CarIdLbl
            // 
            this.CarIdLbl.AutoSize = true;
            this.CarIdLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarIdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdLbl.Location = new System.Drawing.Point(-1, 13);
            this.CarIdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CarIdLbl.Name = "CarIdLbl";
            this.CarIdLbl.Size = new System.Drawing.Size(55, 22);
            this.CarIdLbl.TabIndex = 6;
            this.CarIdLbl.Text = "label1";
            this.CarIdLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            // 
            // rentCarBTn
            // 
            this.rentCarBTn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rentCarBTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCarBTn.ForeColor = System.Drawing.SystemColors.Control;
            this.rentCarBTn.Location = new System.Drawing.Point(243, 268);
            this.rentCarBTn.Name = "rentCarBTn";
            this.rentCarBTn.Size = new System.Drawing.Size(104, 47);
            this.rentCarBTn.TabIndex = 5;
            this.rentCarBTn.Text = "Rent";
            this.rentCarBTn.UseVisualStyleBackColor = false;
            this.rentCarBTn.Click += new System.EventHandler(this.rentCarBTn_Click);
            // 
            // CarImage
            // 
            this.CarImage.Location = new System.Drawing.Point(71, 5);
            this.CarImage.Margin = new System.Windows.Forms.Padding(2);
            this.CarImage.Name = "CarImage";
            this.CarImage.Size = new System.Drawing.Size(260, 147);
            this.CarImage.TabIndex = 3;
            this.CarImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brand:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(78, 247);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(87, 37);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "label3";
            // 
            // ModelLbl
            // 
            this.ModelLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLbl.Location = new System.Drawing.Point(78, 202);
            this.ModelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(87, 37);
            this.ModelLbl.TabIndex = 1;
            this.ModelLbl.Text = "label2";
            // 
            // BrandLbl
            // 
            this.BrandLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BrandLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.Location = new System.Drawing.Point(78, 158);
            this.BrandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(87, 37);
            this.BrandLbl.TabIndex = 0;
            this.BrandLbl.Text = "label1";
            // 
            // DisplayCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpCar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayCar";
            this.Size = new System.Drawing.Size(415, 340);
            this.Load += new System.EventHandler(this.DisplayCar_Load);
            this.flpCar.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCar;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CarIdLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rentCarBTn;
        private System.Windows.Forms.PictureBox CarImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label ModelLbl;
        private System.Windows.Forms.Label BrandLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button AddQuantity;
        private System.Windows.Forms.Button SubQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DailyRateLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label StockLbl;
    }
}
