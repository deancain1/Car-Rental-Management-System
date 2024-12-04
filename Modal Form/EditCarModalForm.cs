using Carl_Rental_System.Database;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Modal_Form
{
    public partial class EditCarModalForm : Form
    {
        private CarsCRUDModel carModel;
        public EditCarModalForm()
        {
            InitializeComponent();
            carModel = new CarsCRUDModel();
        }



        public void EditCarDetails(CarsCRUDModel carModel)
        {
       
            CarIDLbl.Text = carModel.CarID.ToString();
            BrandTxt.Text = carModel.Brand;
            ModelTxt.Text = carModel.Model;
            PriceTxt.Text = $"{carModel.Price:F2}";
            TaxTxt.Text = $"{carModel.Tax:F2}";
            SeatsCB.Text = carModel.Seats;
            GasCB.Text = carModel.Gas;
            TransmissionCB.Text = carModel.Transmission;
            StockTxt.Text = carModel.Stock.ToString();
            DailyRateTxt.Text = $"{carModel.DailyRate:F2}";

            if (carModel.CarImage != null)
            {
                carImageBox.Image = ByteArrayToImage(carModel.CarImage);
            }
             this.carModel = carModel;
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null && byteArrayIn.Length > 0)
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (requiredFields())
            {
                SaveData(); 
                CarsCRUD.UpdateCar(carModel);
                MessageBox.Show("Car details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();  
            }
        }


        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    carImageBox.Image = Image.FromFile(openFileDialog.FileName);
                    carModel.CarImage = File.ReadAllBytes(openFileDialog.FileName);
                }
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
                string.IsNullOrEmpty(DailyRate))
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
            carModel.Brand = BrandTxt.Text.Trim();
            carModel.Model = ModelTxt.Text.Trim();
            carModel.Price = decimal.Parse(PriceTxt.Text.Trim());
            carModel.Tax = decimal.Parse(TaxTxt.Text.Trim());
            carModel.Seats = SeatsCB.Text.Trim();
            carModel.Gas = GasCB.Text.Trim();
            carModel.Transmission = TransmissionCB.Text.Trim();
            carModel.Stock = int.Parse(StockTxt.Text.Trim());
            carModel.DailyRate = decimal.Parse(DailyRateTxt.Text.Trim());
        }

 
        private void exitModal_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            carModel.CarImage = null;
        }

        private void CarIDLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
