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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carl_Rental_System.Modal_Form
{
    public partial class RentedCarsModal : Form
    {
        private RentedCarsModel rentedCars;
        public static RentedCarsModal rentedCarsModal;
        public Label QuantityLbl1;
        public RentedCarsModal()
        {
            InitializeComponent();
            rentedCars = new RentedCarsModel();
            rentedCarsModal = this;
            QuantityLbl1 = QuantityLbl;
         
        }
        public void RentedCarDetails(DisplayCarsModel carsModel, int quantity)
        {
            RentedCarIDLbl.Text = carsModel.CarID.ToString();
            BrandLbl.Text = carsModel.Brand;
            ModelLbl.Text = carsModel.Model;
            PriceLbl.Text = $"${carsModel.Price:F2}";
            TaxLbl.Text = $"${carsModel.Tax:F2}";
            SeatsLbl.Text = carsModel.Seats;
            GasLbl.Text = carsModel.Gas;
            TransmissionLbl.Text = carsModel.Transmission;
            QuantityLbl.Text = quantity.ToString();
            SubtotalLbl.Text = $"${(carsModel.Price * quantity):F2}";
            TotalLbl.Text = $"${(carsModel.Price * quantity + carsModel.Tax):F2}";
            CarImage.Image = ByteArrayToImage(carsModel.CarImage);
           
           
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
            MessageBox.Show("BOOKED SUCCESSFULLY");
            this.Close();
        }
        private void SaveData()
        {
            rentedCars.Brand = BrandLbl.Text;
            rentedCars.Model = ModelLbl.Text;
            rentedCars.Price = decimal.Parse(PriceLbl.Text.Trim('$'));
            rentedCars.Tax = decimal.Parse(TaxLbl.Text.Trim('$'));
            rentedCars.Subtotal = decimal.Parse(SubtotalLbl.Text.Trim('$'));
            rentedCars.Total = decimal.Parse(TotalLbl.Text.Trim('$'));
            rentedCars.Seats = SeatsLbl.Text;
            rentedCars.Gas = GasLbl.Text;
            rentedCars.Transmission = TransmissionLbl.Text.Trim();
            rentedCars.PickUpDate = PickUpDate.Value;
            rentedCars.DropOffDate = DropOffDate.Value;
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
