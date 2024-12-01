using Carl_Rental_System.Database;
using Carl_Rental_System.Modal_Form;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Carl_Rental_System.Forms.Admin_Interface
{
    public partial class UploadCarForm : Form
    {
        public UploadCarForm()
        {
            InitializeComponent();
        }

        private void UploadCarBtn_Click(object sender, EventArgs e)
        {
            UploadCarModalForm modalHandler = new UploadCarModalForm();
            modalHandler.ShowDialog();
        }

        public void RefreshTable()
        {
            DisplayCarData();
        }
       
        public void DisplayCarData()
        {
            CarsCRUD dataAccess = new CarsCRUD();
            List<CarsCRUDModel> carsModels = dataAccess.LoadCarsInDGV(); 

            DGVCars.Rows.Clear();

            foreach (var carModel in carsModels)
            {
                
                int rowIndex = DGVCars.Rows.Add();

                DGVCars.Rows[rowIndex].Cells["carID"].Value = carModel.CarID;
                DGVCars.Rows[rowIndex].Cells["Brand"].Value = carModel.Brand;
                DGVCars.Rows[rowIndex].Cells["Model"].Value = carModel.Model;
                DGVCars.Rows[rowIndex].Cells["Price"].Value = carModel.Price;
                DGVCars.Rows[rowIndex].Cells["Tax"].Value = carModel.Tax;
                DGVCars.Rows[rowIndex].Cells["Seats"].Value = carModel.Seats;
                DGVCars.Rows[rowIndex].Cells["Gas"].Value = carModel.Gas;
                DGVCars.Rows[rowIndex].Cells["Transmission"].Value = carModel.Transmission;
                DGVCars.Rows[rowIndex].Cells["Stock"].Value = carModel.Stock;
                DGVCars.Rows[rowIndex].Cells["DailyRate"].Value = carModel.DailyRate;
                DGVCars.Rows[rowIndex].Cells["CarImage"].Value = carModel.CarImage;

            }
        }

        private void UploadCarForm_Load_1(object sender, EventArgs e)
        {

            DisplayCarData();
        }

        private void DGVCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == DGVCars.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {
             
                int carId = Convert.ToInt32(DGVCars.Rows[e.RowIndex].Cells["CarID"].Value);

                 CarsCRUD db = new CarsCRUD();
                 CarsCRUDModel selectedCarModel = db.GetCarDetailsById(carId);

                 EditCarModalForm editForm = new EditCarModalForm();
                 editForm.EditCarDetails(selectedCarModel);
                 editForm.ShowDialog();
                 DisplayCarData();

            }

            if (e.ColumnIndex == DGVCars.Columns["DeleteBtn"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    int carId = Convert.ToInt32(DGVCars.Rows[rowIndex].Cells["CarID"].Value);

                    CarsCRUD db = new CarsCRUD();
                    db.DeleteCarFromDatabase(carId);

                    DGVCars.Rows.RemoveAt(rowIndex);
                }
            }
        }
    }
}
