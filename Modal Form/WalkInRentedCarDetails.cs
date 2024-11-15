using Carl_Rental_System.Database;
using Carl_Rental_System.DisplayControl;
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
    public partial class WalkInRentedCarDetails : Form
    {
   
        public WalkInRentedCarDetails()
        {
            InitializeComponent();
            
        }
        public void WalkInRentProcess(DisplayCarsModel carsModel, int quantity)
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
            CarImage.Image = ByteArrayToImage(carsModel.CarImage);


            CalculateRentalDetails(carsModel, quantity);
            PickUpDate.ValueChanged += (s, e) => CalculateRentalDetails(carsModel, quantity);
            DropOffDate.ValueChanged += (s, e) => CalculateRentalDetails(carsModel, quantity);
        }

        private void CalculateRentalDetails(DisplayCarsModel carsModel, int quantity)
        {
            SubtotalLbl.Text = $"${(carsModel.Price * quantity):F2}";
            decimal rentalDays = (DropOffDate.Value.Date - PickUpDate.Value.Date).Days;
            rentalDays = rentalDays < 1 ? 1 : rentalDays;
            DailyRateLbl.Text = rentalDays > 0 ? $"${(rentalDays * carsModel.DailyRate):F2}" : $"${carsModel.DailyRate:F2}";
            TotalLbl.Text = $"${((carsModel.Price * quantity) + carsModel.Tax + (carsModel.DailyRate * rentalDays)):F2}";

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
        private void exitModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarDetailsModal_Load(object sender, EventArgs e)
        {

        }
    }
}
