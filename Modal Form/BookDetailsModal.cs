using Carl_Rental_System.Database;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carl_Rental_System.Modal_Form
{

    public partial class BookDetailsModal : Form
    {
        private BookedCarDetailsModel rentedCars;
        public BookDetailsModal()
        {
            InitializeComponent();
            rentedCars = new BookedCarDetailsModel();
        }
        public void BoookedCarDetails(DisplayCarsModel carModel)
        {
            CarIdLbl.Text = carModel.CarID.ToString();
            BrandLbl.Text = carModel.Brand;
            ModelLbl.Text = carModel.Model;
            PriceLbl.Text = $"${carModel.Price:F2}";
            TaxLbl.Text = $"${carModel.Tax:F2}";
            SeatsLbl.Text = carModel.Seats;
            GasLbl.Text = carModel.Gas;
            TransmissionLbl.Text = carModel.Transmission;
            CarImage.Image = ByteArrayToImage(carModel.CarImage);

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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookNowBtn_Click(object sender, EventArgs e)
        {
            int carID = GetCarId();
            if (carID > 0)
            {
                BookedCarDetailsDB db = new BookedCarDetailsDB();
                BookedCarDetailsModel carDetails = db.GetCarDetailsById(carID); 

                if (carDetails.RentedCarID > 0)
                {
                    RentedCarsModal bookdetails = new RentedCarsModal();
                    bookdetails.RentedCarDetails(carDetails);
                    bookdetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This car is not available.");
                }
            }
            SaveData();
            BookedCarDetailsDB.BookedCarDetails(rentedCars);
            
        }

        private int GetCarId()
        {
            int.TryParse(CarIdLbl.Text, out int carID);
            return carID;
        }
        private void SaveData()
        {
            rentedCars.Brand = BrandLbl.Text;
            rentedCars.Model = ModelLbl.Text;
            rentedCars.Price = decimal.Parse(PriceLbl.Text.Trim('$'));
            rentedCars.Tax = decimal.Parse(TaxLbl.Text.Trim('$'));
            rentedCars.Seats = SeatsLbl.Text;
            rentedCars.Gas = GasLbl.Text;
            rentedCars.Transmission = TransmissionLbl.Text.Trim();
         
            rentedCars.Quantity = int.Parse(textBox1.Text.Trim());
            rentedCars.CarImage = ConvertImageToByteArray(CarImage.Image);
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (Bitmap bmp = new Bitmap(image))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                return ms.ToArray();
            }
        }

    }
}
