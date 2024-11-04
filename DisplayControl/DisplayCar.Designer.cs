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
            this.flpCar.Margin = new System.Windows.Forms.Padding(7, 12, 7, 12);
            this.flpCar.Name = "flpCar";
            this.flpCar.Size = new System.Drawing.Size(500, 416);
            this.flpCar.TabIndex = 0;
            // 
            // CardPanel
            // 
            this.CardPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.label3);
            this.CardPanel.Controls.Add(this.CarIdLbl);
            this.CardPanel.Controls.Add(this.label2);
            this.CardPanel.Controls.Add(this.rentCarBTn);
            this.CardPanel.Controls.Add(this.CarImage);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Controls.Add(this.PriceLbl);
            this.CardPanel.Controls.Add(this.ModelLbl);
            this.CardPanel.Controls.Add(this.BrandLbl);
            this.CardPanel.Location = new System.Drawing.Point(15, 4);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Padding = new System.Windows.Forms.Padding(4);
            this.CardPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardPanel.Size = new System.Drawing.Size(437, 359);
            this.CardPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type of Car:";
            // 
            // CarIdLbl
            // 
            this.CarIdLbl.AutoSize = true;
            this.CarIdLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarIdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdLbl.Location = new System.Drawing.Point(321, 207);
            this.CarIdLbl.Name = "CarIdLbl";
            this.CarIdLbl.Size = new System.Drawing.Size(69, 27);
            this.CarIdLbl.TabIndex = 6;
            this.CarIdLbl.Text = "label1";
            this.CarIdLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            // 
            // rentCarBTn
            // 
            this.rentCarBTn.BackColor = System.Drawing.Color.PaleGreen;
            this.rentCarBTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCarBTn.Location = new System.Drawing.Point(255, 302);
            this.rentCarBTn.Margin = new System.Windows.Forms.Padding(4);
            this.rentCarBTn.Name = "rentCarBTn";
            this.rentCarBTn.Size = new System.Drawing.Size(132, 34);
            this.rentCarBTn.TabIndex = 5;
            this.rentCarBTn.Text = "View more";
            this.rentCarBTn.UseVisualStyleBackColor = false;
            this.rentCarBTn.Click += new System.EventHandler(this.rentCarBTn_Click);
            // 
            // CarImage
            // 
            this.CarImage.Location = new System.Drawing.Point(40, 2);
            this.CarImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarImage.Name = "CarImage";
            this.CarImage.Size = new System.Drawing.Size(347, 181);
            this.CarImage.TabIndex = 3;
            this.CarImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brand:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(84, 305);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(62, 26);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "label3";
            // 
            // ModelLbl
            // 
            this.ModelLbl.AutoSize = true;
            this.ModelLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLbl.Location = new System.Drawing.Point(144, 257);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(62, 26);
            this.ModelLbl.TabIndex = 1;
            this.ModelLbl.Text = "label2";
            // 
            // BrandLbl
            // 
            this.BrandLbl.AutoSize = true;
            this.BrandLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.Location = new System.Drawing.Point(84, 210);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(69, 27);
            this.BrandLbl.TabIndex = 0;
            this.BrandLbl.Text = "label1";
            // 
            // DisplayCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpCar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DisplayCar";
            this.Size = new System.Drawing.Size(500, 416);
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
    }
}
