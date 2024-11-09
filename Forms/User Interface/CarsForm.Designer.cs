namespace Carl_Rental_System.Forms.User_Interface
{
    partial class CarsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.FLPDisplayCars = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FLPBrand = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 790);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FLPDisplayCars);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1540, 724);
            this.panel3.TabIndex = 1;
            // 
            // FLPDisplayCars
            // 
            this.FLPDisplayCars.AutoScroll = true;
            this.FLPDisplayCars.BackColor = System.Drawing.Color.White;
            this.FLPDisplayCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPDisplayCars.Location = new System.Drawing.Point(0, 0);
            this.FLPDisplayCars.Margin = new System.Windows.Forms.Padding(2);
            this.FLPDisplayCars.Name = "FLPDisplayCars";
            this.FLPDisplayCars.Size = new System.Drawing.Size(1540, 724);
            this.FLPDisplayCars.TabIndex = 0;
            this.FLPDisplayCars.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPDisplayCars_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FLPBrand);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1540, 66);
            this.panel2.TabIndex = 0;
            // 
            // FLPBrand
            // 
            this.FLPBrand.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FLPBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLPBrand.Location = new System.Drawing.Point(0, 0);
            this.FLPBrand.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.FLPBrand.Name = "FLPBrand";
            this.FLPBrand.Padding = new System.Windows.Forms.Padding(300, 25, 0, 0);
            this.FLPBrand.Size = new System.Drawing.Size(1540, 66);
            this.FLPBrand.TabIndex = 0;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 790);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsForm";
            this.Text = "CarsForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel FLPDisplayCars;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel FLPBrand;
    }
}