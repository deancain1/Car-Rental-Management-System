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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carl_Rental_System.Modal_Form
{
    public partial class RentedCarsModal : Form
    {
        private RentedCarsModel rentedCars;
        public RentedCarsModal()
        {
            InitializeComponent();
            rentedCars = new RentedCarsModel();
        }
        public void RentedCarDetails(BookedCarDetailsModel bookedCar)
        {
            RentedCarIDLbl.Text = bookedCar.RentedCarID.ToString();
            BrandLbl.Text = bookedCar.Brand;
            ModelLbl.Text = bookedCar.Model;
            PriceLbl.Text = $"${bookedCar.Price:F2}";
            TaxLbl.Text = $"${bookedCar.Tax:F2}";
            SeatsLbl.Text = bookedCar.Seats;
            GasLbl.Text = bookedCar.Gas;
            TransmissionLbl.Text = bookedCar.Transmission;
            CarImage.Image = ByteArrayToImage(bookedCar.CarImage);

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

        private void BookNowBtn_Click(object sender, EventArgs e)
        {

            SaveData();
            RentedCarsDB.RentedCars(rentedCars);
           
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

            rentedCars.Quantity = int.Parse(QuantityLbl.Text.Trim());
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
