using Carl_Rental_System.Database;
using Carl_Rental_System.Model;
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
    public partial class ReturnCarForm : Form
    {
        public ReturnCarForm()
        {
            InitializeComponent();
        }
        public void DisplayCarInDGV()
        {

            ReturnedCarDB dataAccess = new ReturnedCarDB();
            List<ReturnedCarModel> carsModels = dataAccess.LoadCarsInDGV();


            DGVRentedCar.Rows.Clear();



            foreach (var carModel in carsModels)
            {

                int rowIndex = DGVRentedCar.Rows.Add();

                DGVRentedCar.Rows[rowIndex].Cells["FullName"].Value = carModel.FullName;
                DGVRentedCar.Rows[rowIndex].Cells["Role"].Value = carModel.Role;
                DGVRentedCar.Rows[rowIndex].Cells["PhoneNumber"].Value = carModel.PhoneNumber;
                DGVRentedCar.Rows[rowIndex].Cells["Model"].Value = carModel.Model;
                DGVRentedCar.Rows[rowIndex].Cells["Total"].Value = carModel.Total;
                DGVRentedCar.Rows[rowIndex].Cells["Price"].Value = carModel.Price;
                DGVRentedCar.Rows[rowIndex].Cells["DailyRate"].Value = carModel.DailyRate;
                DGVRentedCar.Rows[rowIndex].Cells["Total"].Value = carModel.Total;
                DGVRentedCar.Rows[rowIndex].Cells["Gas"].Value = carModel.Gas;
                DGVRentedCar.Rows[rowIndex].Cells["Transmission"].Value = carModel.Transmission;
                DGVRentedCar.Rows[rowIndex].Cells["CarImage"].Value = carModel.CarImage;
                DGVRentedCar.Rows[rowIndex].Cells["Quantity"].Value = carModel.Quantity;
                DGVRentedCar.Rows[rowIndex].Cells["PickUpDate"].Value = carModel.PickUpDate;
                DGVRentedCar.Rows[rowIndex].Cells["DropOffDate"].Value = carModel.DropOffDate;





            }
        }

        private void ReturnCarForm_Load(object sender, EventArgs e)
        {
            DisplayCarInDGV();
        }
    }
}
