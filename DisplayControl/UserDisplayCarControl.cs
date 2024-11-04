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
                QuantityLbl.Text = carsModel.Quantity.ToString();
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
                    BookDetailsModal detailsForm = new BookDetailsModal();
                    detailsForm.BoookedCarDetails(carDetails);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This car is not available.");
                }
            }
        }

    

    private int GetCarId()
        {
            int.TryParse(CarIdLbl.Text, out int carID);
            return carID;
        }

        private void CarImage_Click(object sender, EventArgs e)
        {

        }
    }
}
