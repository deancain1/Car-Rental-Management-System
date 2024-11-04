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
using System.IO;
using System.Windows.Forms;
using Carl_Rental_System.Forms;
using Carl_Rental_System.Forms.Admin_Interface;

namespace Carl_Rental_System.Modal_Form
{
    public partial class AddCarModalFormcs : Form
    {
        private AddNewCarDB db;
        private AddNewCarModel newcarmodel;
        
        public AddCarModalFormcs()
        {

            newcarmodel = new AddNewCarModel();
          
            db = new AddNewCarDB();
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {

            if (requiredFields())
            {

                SaveData();
                AddNewCarDB.AddNewCar(newcarmodel);
                ClearFields();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (requiredFields())
            {
                SaveData();
                AddNewCarDB.UpdateCar(newcarmodel);
                ClearFields();
            }
        }
        private bool requiredFields()
        {
            string Brand = brand.Text;
        
            string Model = carName.Text;
            string PriceText = price.Text;
            string TaxText = tax.Text;
            string Seats = seats.Text;
            string Gas = gas.Text;
            string Transmission = transmission.Text;
            string Quantity = QuantityTxt.Text;

            if (string.IsNullOrEmpty(Brand) ||
                string.IsNullOrEmpty(Model) ||
                string.IsNullOrEmpty(PriceText) ||
                string.IsNullOrEmpty(TaxText) ||
                string.IsNullOrEmpty(Seats) ||
                string.IsNullOrEmpty(Gas) ||
                string.IsNullOrEmpty(Transmission)
                )
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(PriceText, out decimal Price))

            {
                MessageBox.Show("Please enter a valid number for price", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            return true;
        }
        private void SaveData()
        {
        

            newcarmodel.Brand = brand.Text.Trim();
            newcarmodel.Model = carName.Text.Trim();
            newcarmodel.Price = decimal.Parse(price.Text.Trim());
            newcarmodel.Tax = decimal.Parse(tax.Text.Trim());
            newcarmodel.Seats = seats.Text.Trim();
            newcarmodel.Gas = gas.Text.Trim();
            newcarmodel.Transmission = transmission.Text.Trim();
            newcarmodel.Quantity = int.Parse(QuantityTxt.Text.Trim());



        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    carImageBox.Image = Image.FromFile(openFileDialog.FileName);
                    newcarmodel.CarImage = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }
        private void ClearFields()
        {
            brand.Clear();
           
            carName.Clear();
            price.Clear();
            tax.Clear();
            seats.SelectedItem = null;
            gas.SelectedItem = null;
            transmission.SelectedItem = null;
            QuantityTxt.Clear();
            newcarmodel.CarImage = null;
        }

        private void exitModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
