namespace Carl_Rental_System.Forms.Admin_Interface
{
    partial class UploadCarForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.DeleteData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.CarImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Transmission = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Seats = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Price = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.CarName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.PlateNumber = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Brand = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.CarId = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.DataGridViewCarDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Gas = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.EditCarBtn = new System.Windows.Forms.Button();
            this.UploadCarBtn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EditCarBtn);
            this.panel3.Controls.Add(this.UploadCarBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1291, 55);
            this.panel3.TabIndex = 8;
           
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            // 
            // DeleteData
            // 
            this.DeleteData.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.DeleteData.HeaderText = "Delete";
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.ReadOnly = true;
            this.DeleteData.Text = "Delete";
            this.DeleteData.UseColumnTextForButtonValue = true;
            this.DeleteData.Width = 127;
            // 
            // CarImage
            // 
            this.CarImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarImage.HeaderText = "Car Image";
            this.CarImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.CarImage.Name = "CarImage";
            this.CarImage.ReadOnly = true;
            // 
            // Transmission
            // 
            this.Transmission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Transmission.HeaderText = "Transmission";
            this.Transmission.Name = "Transmission";
            this.Transmission.ReadOnly = true;
            this.Transmission.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transmission.Width = 125;
            // 
            // Seats
            // 
            this.Seats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seats.HeaderText = "Seats";
            this.Seats.Name = "Seats";
            this.Seats.ReadOnly = true;
            this.Seats.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seats.Width = 125;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 125;
            // 
            // CarName
            // 
            this.CarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarName.HeaderText = "Car Name";
            this.CarName.Name = "CarName";
            this.CarName.ReadOnly = true;
            this.CarName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CarName.Width = 125;
            // 
            // PlateNumber
            // 
            this.PlateNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlateNumber.HeaderText = "Plate Number";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            this.PlateNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlateNumber.Width = 124;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Brand.Width = 125;
            // 
            // CarId
            // 
            this.CarId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarId.HeaderText = "Car ID";
            this.CarId.Name = "CarId";
            this.CarId.ReadOnly = true;
            this.CarId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CarId.Width = 125;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.DataGridViewCarDetails);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 58);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1291, 708);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // DataGridViewCarDetails
            // 
            this.DataGridViewCarDetails.ColumnHeadersHeight = 40;
            this.DataGridViewCarDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.Brand,
            this.PlateNumber,
            this.CarName,
            this.Price,
            this.Seats,
            this.Gas,
            this.Transmission,
            this.CarImage,
            this.DeleteData});
            this.DataGridViewCarDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCarDetails.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.DataGridViewCarDetails.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.DataGridViewCarDetails.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridViewCarDetails.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridViewCarDetails.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridViewCarDetails.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewCarDetails.Name = "DataGridViewCarDetails";
            this.DataGridViewCarDetails.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DataGridViewCarDetails.RowTemplate.Height = 50;
            this.DataGridViewCarDetails.RowTemplate.ReadOnly = true;
            this.DataGridViewCarDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewCarDetails.Size = new System.Drawing.Size(1291, 708);
            this.DataGridViewCarDetails.TabIndex = 0;
            // 
            // Gas
            // 
            this.Gas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gas.HeaderText = "Gas";
            this.Gas.Name = "Gas";
            this.Gas.ReadOnly = true;
            this.Gas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gas.Width = 124;
            // 
            // EditCarBtn
            // 
            this.EditCarBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.EditCarBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EditCarBtn.Location = new System.Drawing.Point(167, 8);
            this.EditCarBtn.Name = "EditCarBtn";
            this.EditCarBtn.Size = new System.Drawing.Size(158, 44);
            this.EditCarBtn.TabIndex = 8;
            this.EditCarBtn.Text = "Edit";
            this.EditCarBtn.UseVisualStyleBackColor = false;
            // 
            // UploadCarBtn
            // 
            this.UploadCarBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UploadCarBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadCarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UploadCarBtn.Image = global::Carl_Rental_System.Properties.Resources.icons8_plus_math_25;
            this.UploadCarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UploadCarBtn.Location = new System.Drawing.Point(3, 8);
            this.UploadCarBtn.Name = "UploadCarBtn";
            this.UploadCarBtn.Size = new System.Drawing.Size(158, 44);
            this.UploadCarBtn.TabIndex = 6;
            this.UploadCarBtn.Text = "   Upload Car";
            this.UploadCarBtn.UseVisualStyleBackColor = false;
            this.UploadCarBtn.Click += new System.EventHandler(this.UploadCarBtn_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Car Image";
            this.dataGridViewImageColumn1.Image = global::Carl_Rental_System.Properties.Resources.car1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 81;
            // 
            // UploadCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 766);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadCarForm";
            this.Text = "UploadCarForm";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn DeleteData;
        private System.Windows.Forms.DataGridViewImageColumn CarImage;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Transmission;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Seats;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Price;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn CarName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PlateNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Brand;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn CarId;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewCarDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Gas;
        private System.Windows.Forms.Button UploadCarBtn;
        private System.Windows.Forms.Button EditCarBtn;
    }
}