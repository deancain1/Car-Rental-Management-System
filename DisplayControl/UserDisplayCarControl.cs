using Carl_Rental_System.Database;
using Carl_Rental_System.Domain;
using Carl_Rental_System.Modal_Form;
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
    public partial class UserDisplayCarControl : UserControl
    {
 
        private DisplayCarsModel carsModel;


        public UserDisplayCarControl(DisplayCarsModel carModels)
        {

            this.carsModel = carModels;
            InitializeComponent();
            InitializeCarDetails();
        }

        private void InitializeCarDetails()
        {
            if (carsModel != null)
            {
                CarIdLbl.Text = carsModel.CarID.ToString();
                BrandLbl.Text = carsModel.Brand;
                ModelLbl.Text = carsModel.Model;
                PriceLbl.Text = $"${carsModel.Price:F2}";
                SeatsLbl.Text = carsModel.Seats;
                GasLbl.Text = carsModel.Gas;
                TransmissionLbl.Text = carsModel.Transmission;
                AvailabilityLbl.Text = carsModel.Availability.ToString();
                CarImage.Image = ByteArrayToImage(carsModel.CarImage);
             
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

        private void BookNowBtn_Click(object sender, EventArgs e)
        {
            int carID = GetCarId();
            if (carID > 0)
            {
                DisplayCarsDB db = new DisplayCarsDB();
                DisplayCarsModel carDetails = db.GetCarDetailsById(carID);

                if (carDetails.CarID > 0)
                {
                    RentedCarsModal detailsForm = new RentedCarsModal();
                    int quantity = QuantityValue();
                    detailsForm.RentedCarDetails(carDetails, quantity);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This car is not available.");
                }
            }
        }

        private int QuantityValue()
        {
            int.TryParse(QuantityLbl.Text, out int Quantity);
    
            return Quantity;
        }
        private int GetCarId()
        {
            int.TryParse(CarIdLbl.Text, out int carID);
            return carID;
        }


        int quantity = 1;
        const int maxQuantity = 100;

        private void AddQuantity_Click(object sender, EventArgs e)
        {
            if (quantity < maxQuantity)
            {
                quantity++;
                QuantityLbl.Text = quantity.ToString();
               
            }
        }

        private void SubQuantity_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                QuantityLbl.Text = quantity.ToString();
               
            }

        }

        private void UserDisplayCarControl_Load(object sender, EventArgs e)
        {
            QuantityLbl.Text = quantity.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
