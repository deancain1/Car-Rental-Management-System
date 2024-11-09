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

namespace Carl_Rental_System.Forms.User_Interface
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            DisplayCars();
            NavigationBrand();


        }
        private void DisplayCars(string brand = null) 
        {
            FLPDisplayCars.Controls.Clear();
            var cars = brand == null ?  DisplayCarsDB.DisplayCar() : DisplayCarsDB.DisplayCarBrand(brand);
            if (!cars.Any())
            {
                MessageBox.Show("No Cars Available");
                return;
            }
            foreach (var car in cars)
            {
                UserDisplayCarControl displayCar = new UserDisplayCarControl(car);
                FLPDisplayCars.Controls.Add(displayCar);    
           
            }
        }
        private void NavigationBrand()
        {
            List<string> Brands = new List<string>
            {
                "Available Cars   " , "Toyota   " ,"Honda   ", "Mitsubishi   ", "Suzuki   ","Ford   ","Hyundai   " , "Kia   "
            };
            foreach (var Brand in Brands)
            {
                Label BrandLbl = new Label();
                {
                    Cursor = Cursors.Hand;
                    BrandLbl.AutoSize = true;

                }
                BrandLbl.Text = Brand;
                FLPBrand.Controls.Add(BrandLbl);
                BrandLbl.Click += (s, e) =>
                {
                    if (Brand == "Available Cars   ")
                    {
                        DisplayCars(null);
                    }
                    else
                    {
                        DisplayCars(Brand);
                    }
                };
            }

        }
        public void  RefreshCarDetails()
        {
            DisplayCars();
        }

        private void FLPDisplayCars_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
