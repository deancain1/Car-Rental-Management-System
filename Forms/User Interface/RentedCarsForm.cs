using Carl_Rental_System.Database;
using Carl_Rental_System.DisplayControl;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Forms.User_Interface
{
    public partial class RentedCarsForm : Form
    {
  
        public RentedCarsForm()
        {
            InitializeComponent();
            DisplayRentedCars();
        }
        private void DisplayRentedCars()
        {
            FLPRentedCars.Controls.Clear();
            var cars = RentedCarsDB.LoadRentedCar();

            if (!cars.Any())
            {
                MessageBox.Show("No Cars Rented");
                return;
            }

            decimal totalSum = 0;
            int totalQuantity = 0;
            foreach (var rentedCar in cars)
            {
              
                totalSum += rentedCar.Total;
                totalQuantity += rentedCar.Quantity;
                RentedCarsControl displayCar = new RentedCarsControl(rentedCar);
                FLPRentedCars.Controls.Add(displayCar);
            }

            ItemLbl.Text = totalQuantity.ToString();
            TotalLbl.Text = $"Total: ${totalSum:F2}";
        }
    }
}
