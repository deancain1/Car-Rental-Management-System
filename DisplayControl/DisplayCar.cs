using Carl_Rental_System.Database;
using Carl_Rental_System.Domain;
using Carl_Rental_System.Forms;
using Carl_Rental_System.Modal;
using Carl_Rental_System.Modal_Form;
using Carl_Rental_System.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carl_Rental_System.DisplayControl
{
    public partial class DisplayCar : UserControl
    {


        private DisplayCarsModel car;

        public DisplayCar(DisplayCarsModel car)
        {
            InitializeComponent();
            this.car = car;
            InitializeCarDetails();
        }

        private void InitializeCarDetails()
        {
            if (car != null)
            {
                CarIdLbl.Text = car.CarID.ToString();
                ModelLbl.Text = car.Model;
                BrandLbl.Text = car.Brand;
                PriceLbl.Text = $"{car.Price:F2}";
                CarImage.Image = ByteArrayToImage(car.CarImage);
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

        private void rentCarBTn_Click(object sender, EventArgs e)
        {
            int carID = GetCarId();
            if (carID > 0)
            {
                DisplayCarsDB db = new DisplayCarsDB();
                DisplayCarsModel carDetails = db.GetCarDetailsById(carID);

                if (carDetails.CarID > 0)
                {
                    CarDetails detailsForm = new CarDetails();
                    detailsForm.DisplayCarDetails(carDetails);
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
    }
}


