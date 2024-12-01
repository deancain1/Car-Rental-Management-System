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


        private DisplayCarsModel carModel;

        public DisplayCar(DisplayCarsModel car)
        {
            InitializeComponent();
            this.carModel = car;
            InitializeCarDetails();
        }

        private void InitializeCarDetails()
        {
                CarIdLbl.Text = carModel.CarID.ToString();
                ModelLbl.Text = carModel.Model;
                BrandLbl.Text = carModel.Brand;
                PriceLbl.Text = $"${carModel.Price:F2}";
                StockLbl.Text = carModel.Stock.ToString();
                DailyRateLbl.Text = $"${carModel.DailyRate:F2}";
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

        private void rentCarBTn_Click(object sender, EventArgs e)
        {
            int carID = GetCarId();
            int quantity = QuantityValue();
            if (carID > 0)
            {
                DisplayCarsDB db = new DisplayCarsDB();
                db.GetCarDetailsById(carID);

                if (carModel.CarID > 0)
                {
                    if (carModel.Stock == 0)
                    {
                        MessageBox.Show("Not available", "Out of Stock", MessageBoxButtons.OK);
                        return;

                    }
                    if (carModel.Stock < quantity)
                    {
                        MessageBox.Show("The maximum stock has been  exceeded.", "", MessageBoxButtons.OK);
                        return;
                    }
                    RentingDetails detailsForm = new RentingDetails();

                    detailsForm.WalkInRentalDetails(carModel, quantity);

                    if (detailsForm.ShowDialog() == DialogResult.OK)
                    {

                        int newStock = carModel.Stock - detailsForm.rentedQuantity;
                        if (newStock >= 0)
                        {
                            RentedCarsDB database = new RentedCarsDB();
                            carModel.Stock = newStock;
                            database.UpdateStock(carModel);
                            DisplayCarsDB displayCarsDB = new DisplayCarsDB();
                            StockLbl.Text = newStock.ToString();

                        }
                    }
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


