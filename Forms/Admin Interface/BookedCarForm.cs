using Carl_Rental_System.Database;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Carl_Rental_System.Forms.Admin_Interface
{
    public partial class BookedCarForm : Form
    {
        public BookedCarForm()
        {
            InitializeComponent();
        }

        public void DisplayCarInDGV(string searchTerm = "")
        {
            BookingCarDB dataAccess = new BookingCarDB();
            List<BookingModel> carsModels = dataAccess.LoadCarsInDGV();

        
              carsModels = carsModels.Where(
                  car => car.FullName.ToLower().Contains(searchTerm.ToLower()) ||        
                  car.PhoneNumber.Contains(searchTerm) ||
                  car.Model.ToLower().Contains(searchTerm.ToLower())).ToList();
            

            DGVBookedCar.Rows.Clear();

            foreach (var carModel in carsModels)
            {
                int rowIndex = DGVBookedCar.Rows.Add();
                DGVBookedCar.Rows[rowIndex].Cells["BookCarID"].Value = carModel.BookCarID;
                DGVBookedCar.Rows[rowIndex].Cells["FullName"].Value = carModel.FullName;
                DGVBookedCar.Rows[rowIndex].Cells["PhoneNumber"].Value = carModel.PhoneNumber;
                DGVBookedCar.Rows[rowIndex].Cells["Model"].Value = carModel.Model;
                DGVBookedCar.Rows[rowIndex].Cells["Total"].Value = carModel.Total;
                DGVBookedCar.Rows[rowIndex].Cells["Price"].Value = carModel.Price;
                DGVBookedCar.Rows[rowIndex].Cells["DailyRate"].Value = carModel.DailyRate;
                DGVBookedCar.Rows[rowIndex].Cells["Gas"].Value = carModel.Gas;
                DGVBookedCar.Rows[rowIndex].Cells["Transmission"].Value = carModel.Transmission;
                DGVBookedCar.Rows[rowIndex].Cells["CarImage"].Value = carModel.CarImage;
                DGVBookedCar.Rows[rowIndex].Cells["Quantity"].Value = carModel.Quantity;
                DGVBookedCar.Rows[rowIndex].Cells["PickUpDate"].Value = carModel.PickUpDate;
                DGVBookedCar.Rows[rowIndex].Cells["DropOffDate"].Value = carModel.DropOffDate;
            }
        }

        private void BookedCarForm_Load(object sender, EventArgs e)
        {
            DisplayCarInDGV();  
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            string searchTerm = SearchTxt.Text.Trim();
            DisplayCarInDGV(searchTerm);
        }
        private void DGVBookedCar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVBookedCar.Columns["TransferBtn"].Index)
            {
                DataGridViewRow selectedRow = DGVBookedCar.Rows[e.RowIndex];
                int bookingID = Convert.ToInt32(selectedRow.Cells["BookCarID"].Value);

                BookingCarDB bookingCarDB = new BookingCarDB();
                bookingCarDB.TransferBookToRentedCar(bookingID);
                DisplayCarInDGV();  
            }
        }

     
    }
}
