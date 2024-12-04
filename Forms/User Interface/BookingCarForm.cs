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
    public partial class BookingCarForm : Form
    {
  
        public BookingCarForm()
        {
            InitializeComponent();
            DisplayBookedCar();
        }
        private void DisplayBookedCar()
        {
            FLPRentedCars.Controls.Clear();
            var cars = BookingCarDB.LoadBookingCar();  

       
            decimal totalSum = 0;
            int totalQuantity = 0;
            foreach (var bookCar in cars)
            {
                totalSum += bookCar.Total;
                totalQuantity += bookCar.Quantity;
                BookingCarControl displayCar = new BookingCarControl(bookCar);
                displayCar.CarDeleted += DisplayCar_CarDeleted; 
                FLPRentedCars.Controls.Add(displayCar);
            }

            ItemLbl.Text = totalQuantity.ToString();
            TotalLbl.Text = $"Total: ${totalSum:F2}";
        }

        private void DisplayCar_CarDeleted(object sender, EventArgs e)
        {

            DisplayBookedCar();
        }
    }
}
