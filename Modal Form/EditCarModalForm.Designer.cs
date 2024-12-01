namespace Carl_Rental_System.Modal_Form
{
    partial class EditCarModalForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StockTxt = new System.Windows.Forms.TextBox();
            this.TaxTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exitModal = new System.Windows.Forms.Label();
            this.DailyRateTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.carImageBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GasCB = new System.Windows.Forms.ComboBox();
            this.TransmissionCB = new System.Windows.Forms.ComboBox();
            this.SeatsCB = new System.Windows.Forms.ComboBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.BrandTxt = new System.Windows.Forms.TextBox();
            this.CarIDLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 22);
            this.label10.TabIndex = 102;
            this.label10.Text = "Daily Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 22);
            this.label9.TabIndex = 100;
            this.label9.Text = "Stock";
            // 
            // StockTxt
            // 
            this.StockTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTxt.Location = new System.Drawing.Point(349, 102);
            this.StockTxt.Margin = new System.Windows.Forms.Padding(2);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(240, 34);
            this.StockTxt.TabIndex = 99;
            // 
            // TaxTxt
            // 
            this.TaxTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxt.Location = new System.Drawing.Point(52, 398);
            this.TaxTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TaxTxt.Name = "TaxTxt";
            this.TaxTxt.Size = new System.Drawing.Size(240, 34);
            this.TaxTxt.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 97;
            this.label2.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 26);
            this.label8.TabIndex = 75;
            this.label8.Text = "UPDATE CAR";
            // 
            // exitModal
            // 
            this.exitModal.AutoSize = true;
            this.exitModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitModal.ForeColor = System.Drawing.Color.DarkRed;
            this.exitModal.Location = new System.Drawing.Point(892, 14);
            this.exitModal.Name = "exitModal";
            this.exitModal.Size = new System.Drawing.Size(25, 24);
            this.exitModal.TabIndex = 5;
            this.exitModal.Text = "X";
            this.exitModal.Click += new System.EventHandler(this.exitModal_Click_1);
            // 
            // DailyRateTxt
            // 
            this.DailyRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRateTxt.Location = new System.Drawing.Point(349, 192);
            this.DailyRateTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DailyRateTxt.Name = "DailyRateTxt";
            this.DailyRateTxt.Size = new System.Drawing.Size(240, 31);
            this.DailyRateTxt.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.exitModal);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 49);
            this.panel1.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 95;
            this.label4.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 94;
            this.label1.Text = "Brand";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackColor = System.Drawing.Color.Azure;
            this.BrowseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.Location = new System.Drawing.Point(774, 227);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(104, 49);
            this.BrowseBtn.TabIndex = 93;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = false;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Navy;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(649, 227);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 49);
            this.UpdateBtn.TabIndex = 92;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // carImageBox
            // 
            this.carImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carImageBox.Location = new System.Drawing.Point(629, 63);
            this.carImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.carImageBox.Name = "carImageBox";
            this.carImageBox.Size = new System.Drawing.Size(260, 147);
            this.carImageBox.TabIndex = 91;
            this.carImageBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 393);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 90;
            this.label7.Text = "Transmission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 89;
            this.label6.Text = "Gas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 88;
            this.label5.Text = "Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 87;
            this.label3.Text = "Model";
            // 
            // GasCB
            // 
            this.GasCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasCB.FormattingEnabled = true;
            this.GasCB.Items.AddRange(new object[] {
            "Premium",
            "Unledead",
            "Diesel"});
            this.GasCB.Location = new System.Drawing.Point(355, 352);
            this.GasCB.Margin = new System.Windows.Forms.Padding(2);
            this.GasCB.Name = "GasCB";
            this.GasCB.Size = new System.Drawing.Size(234, 28);
            this.GasCB.TabIndex = 86;
            // 
            // TransmissionCB
            // 
            this.TransmissionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmissionCB.FormattingEnabled = true;
            this.TransmissionCB.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.TransmissionCB.Location = new System.Drawing.Point(355, 426);
            this.TransmissionCB.Margin = new System.Windows.Forms.Padding(2);
            this.TransmissionCB.Name = "TransmissionCB";
            this.TransmissionCB.Size = new System.Drawing.Size(234, 28);
            this.TransmissionCB.TabIndex = 85;
            // 
            // SeatsCB
            // 
            this.SeatsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsCB.FormattingEnabled = true;
            this.SeatsCB.Items.AddRange(new object[] {
            "4 seats",
            "5 seats",
            "6 seats",
            "8 seats"});
            this.SeatsCB.Location = new System.Drawing.Point(355, 291);
            this.SeatsCB.Margin = new System.Windows.Forms.Padding(2);
            this.SeatsCB.Name = "SeatsCB";
            this.SeatsCB.Size = new System.Drawing.Size(234, 28);
            this.SeatsCB.TabIndex = 84;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.Location = new System.Drawing.Point(49, 289);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(240, 34);
            this.PriceTxt.TabIndex = 83;
            // 
            // ModelTxt
            // 
            this.ModelTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTxt.Location = new System.Drawing.Point(49, 189);
            this.ModelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(240, 34);
            this.ModelTxt.TabIndex = 82;
            // 
            // BrandTxt
            // 
            this.BrandTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandTxt.Location = new System.Drawing.Point(49, 102);
            this.BrandTxt.Margin = new System.Windows.Forms.Padding(2);
            this.BrandTxt.Name = "BrandTxt";
            this.BrandTxt.Size = new System.Drawing.Size(240, 34);
            this.BrandTxt.TabIndex = 81;
            // 
            // CarIDLbl
            // 
            this.CarIDLbl.AutoSize = true;
            this.CarIDLbl.Location = new System.Drawing.Point(50, 485);
            this.CarIDLbl.Name = "CarIDLbl";
            this.CarIDLbl.Size = new System.Drawing.Size(41, 13);
            this.CarIDLbl.TabIndex = 103;
            this.CarIDLbl.Text = "label11";
            this.CarIDLbl.Click += new System.EventHandler(this.CarIDLbl_Click);
            // 
            // EditCarModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 507);
            this.Controls.Add(this.CarIDLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StockTxt);
            this.Controls.Add(this.TaxTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DailyRateTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.carImageBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GasCB);
            this.Controls.Add(this.TransmissionCB);
            this.Controls.Add(this.SeatsCB);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.BrandTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditCarModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCarModalForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StockTxt;
        private System.Windows.Forms.TextBox TaxTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label exitModal;
        private System.Windows.Forms.TextBox DailyRateTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.PictureBox carImageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GasCB;
        private System.Windows.Forms.ComboBox TransmissionCB;
        private System.Windows.Forms.ComboBox SeatsCB;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.TextBox BrandTxt;
        private System.Windows.Forms.Label CarIDLbl;
    }
}