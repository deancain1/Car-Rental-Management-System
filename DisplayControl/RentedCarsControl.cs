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

namespace Carl_Rental_System.DisplayControl
{
    public partial class RentedCarsControl : UserControl
    {
        private RentedCarsModel rentedCars;

        public RentedCarsControl(RentedCarsModel rentedCars)
        {
            this.rentedCars = rentedCars;
            InitializeComponent();
            InitializeCarDetails();
        }
        private void InitializeCarDetails()
        {
            if (rentedCars != null)
            {
                CarRentedIDLbl.Text = rentedCars.CarRentedID.ToString();
                BrandLbl.Text = rentedCars.Brand;
                ModelLbl.Text = rentedCars.Model;
                PriceLbl.Text = $"${rentedCars.Price:F2}";
                TaxLbl.Text = $"${rentedCars.Tax:F2}";
                SubtotalLbl.Text = $"${rentedCars.Subtotal:F2}";
                DailyRateLbl.Text = $"${rentedCars.DailyRate:F2}";
                TotalLbl.Text = $"${rentedCars.Total:F2}";
                SeatsLbl.Text = rentedCars.Seats;
                GasLbl.Text = rentedCars.Gas;
                TransmissionLbl.Text = rentedCars.Transmission;
                QuantityLbl.Text = rentedCars.Quantity.ToString();
                CarImage.Image = ByteArrayToImage(rentedCars.CarImage);
                PickUpDateLbl.Text = rentedCars.PickUpDate.ToString("MMMM dd, yyyy"); 
                DropOffDateLbl.Text = rentedCars.DropOffDate.ToString("MMMM dd, yyyy");

            }


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
    }
}
