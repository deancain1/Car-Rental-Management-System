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
    public partial class RentedCarForm : Form
    {
        public RentedCarForm()
        {
            InitializeComponent();
        }
        public void DisplayCarInDGV(string searchTerm = "")
        {

            RentedCarsDB dataAccess = new RentedCarsDB();
            List<RentedCarsModel> carsModels = dataAccess.LoadCarsInDGV();

            carsModels = carsModels.Where(
                 car => car.FullName.ToLower().Contains(searchTerm.ToLower()) ||
                 car.PhoneNumber.Contains(searchTerm) ||
                 car.Model.ToLower().Contains(searchTerm.ToLower())).ToList();


            DGVRentedCar.Rows.Clear();



            foreach (var carModel in carsModels)
            {

                int rowIndex = DGVRentedCar.Rows.Add();
                DGVRentedCar.Rows[rowIndex].Cells["CarRentedID"].Value = carModel.CarRentedID;
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxt.Text.Trim();
            DisplayCarInDGV(searchTerm);
        }

        private void RentedCarForm_Load(object sender, EventArgs e)
        {
            DisplayCarInDGV();
        }

        private void DGVRentedCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVRentedCar.Columns["ReturnBtn"].Index)
            {

                DataGridViewRow selectedRow = DGVRentedCar.Rows[e.RowIndex];

                int CarRentedID = Convert.ToInt32(selectedRow.Cells["CarRentedID"].Value);

                RentedCarsDB bookingCarDB = new RentedCarsDB();
                bookingCarDB.TransferRentedCarToReturned(CarRentedID);
                DisplayCarInDGV();

            }
        }

    }
}

