using Carl_Rental_System.Database;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Carl_Rental_System.Forms;
using Carl_Rental_System.Forms.Admin_Interface;

namespace Carl_Rental_System.Modal_Form
{
    public partial class UploadCarModalForm : Form
    {
        private AddNewCarDB db;
        private AddNewCarModel newcarmodel;
        
        public UploadCarModalForm()
        {

            newcarmodel = new AddNewCarModel();
          
            db = new AddNewCarDB();
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {

            if (requiredFields())
            {

                SaveData();
                AddNewCarDB.AddNewCar(newcarmodel);
                ClearFields();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (requiredFields())
            {
                SaveData();
                AddNewCarDB.UpdateCar(newcarmodel);
                ClearFields();
            }
        }
        private bool requiredFields()
        {
            string Brand = BrandTxt.Text;
        
            string Model = ModelTxt.Text;
            string PriceText = PriceTxt.Text;
            string TaxText = TaxTxt.Text;
            string Seats = SeatsCB.Text;
            string Gas = GasCB.Text;
            string Transmission = TransmissionCB.Text;
            string Stock = StockTxt.Text;
            string DailyRate = DailyRateTxt.Text;

            if (string.IsNullOrEmpty(Brand) ||
                string.IsNullOrEmpty(Model) ||
                string.IsNullOrEmpty(PriceText) ||
                string.IsNullOrEmpty(TaxText) ||
                string.IsNullOrEmpty(Seats) ||
                string.IsNullOrEmpty(Gas) ||
                string.IsNullOrEmpty(Transmission) ||
                string.IsNullOrEmpty(Stock) ||
                string.IsNullOrEmpty(DailyRate)
                )
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(PriceText, out decimal Price))

            {
                MessageBox.Show("Please enter a valid number for price", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            return true;
        }
        private void SaveData()
        {
        

            newcarmodel.Brand = BrandTxt.Text.Trim();
            newcarmodel.Model = ModelTxt.Text.Trim();
            newcarmodel.Price = decimal.Parse(PriceTxt.Text.Trim());
            newcarmodel.Tax = decimal.Parse(TaxTxt.Text.Trim());
            newcarmodel.Seats = SeatsCB.Text.Trim();
            newcarmodel.Gas = GasCB.Text.Trim();
            newcarmodel.Transmission = TransmissionCB.Text.Trim();
            newcarmodel.Stock = int.Parse(StockTxt.Text.Trim());
            newcarmodel.DailyRate = decimal.Parse(DailyRateTxt.Text.Trim());



        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    carImageBox.Image = Image.FromFile(openFileDialog.FileName);
                    newcarmodel.CarImage = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }
        private void ClearFields()
        {
            BrandTxt.Clear();
           
            ModelTxt.Clear();
            PriceTxt.Clear();
            TaxTxt.Clear();
            SeatsCB.SelectedItem = null;
            GasCB.SelectedItem = null;
            TransmissionCB.SelectedItem = null;
            StockTxt.Clear();
            DailyRateTxt.Clear();
            newcarmodel.CarImage = null;
        }

        private void exitModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
