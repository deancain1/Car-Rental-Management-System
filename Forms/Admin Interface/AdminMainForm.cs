using Carl_Rental_System.Database;
using Carl_Rental_System.DisplayControl;
using Carl_Rental_System.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Forms.Admin_Interface
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            DisplayCars();
        }
        private void DisplayCars()
        {
            flowLayoutPanel1.Controls.Clear();
            var cars = DisplayCarsDB.DisplayCar();
      
            foreach (var car in cars)
            {
                DisplayCar displayCar = new DisplayCar(car);
                flowLayoutPanel1.Controls.Add(displayCar);

            }
        }



        public void RefreshCarData()
        {

         DisplayCars();
        }
    }
}
