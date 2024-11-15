using Carl_Rental_System.Database;

using Carl_Rental_System.Forms;
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
                PriceLbl.Text = $"${car.Price:F2}";
                StockLbl.Text = car.Stock.ToString();
                DailyRateLbl.Text = $"${car.DailyRate:F2}";
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
            int quantity = QuantityValue();
            if (carID > 0)
            {
                DisplayCarsDB db = new DisplayCarsDB();
                DisplayCarsModel carDetails = db.GetCarDetailsById(carID);

                if (carDetails.CarID > 0)
                {
                    WalkInRentedCarDetails detailsForm = new WalkInRentedCarDetails();
                    detailsForm.WalkInRentProcess(carDetails, quantity);
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
       
        private void DisplayCar_Load(object sender, EventArgs e)
        {
            QuantityLbl.Text = quantity.ToString();
        }
    }
}


