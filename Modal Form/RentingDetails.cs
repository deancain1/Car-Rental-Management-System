﻿using Carl_Rental_System.Database;
using Carl_Rental_System.DisplayControl;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Modal_Form
{
    public partial class RentingDetails : Form
    {
        private RentedCarsModel rentedCarsModel;
        private int RentedQuantity;
        public int rentedQuantity => RentedQuantity;
        public RentingDetails()
        {
            rentedCarsModel = new RentedCarsModel();
            InitializeComponent();
            
        }
        public void WalkInRentalDetails(DisplayCarsModel carsModel, int quantity)
        {
            RentedQuantity = quantity;
            RentedCarIDLbl.Text = carsModel.CarID.ToString();
            BrandLbl.Text = carsModel.Brand;
            ModelLbl.Text = carsModel.Model;
            PriceLbl.Text = $"${carsModel.Price:F2}";
            TaxLbl.Text = $"${carsModel.Tax:F2}";
            SeatsLbl.Text = carsModel.Seats;
            GasLbl.Text = carsModel.Gas;
            TransmissionLbl.Text = carsModel.Transmission;
            QuantityLbl.Text = quantity.ToString();
            CarImage.Image = ByteArrayToImage(carsModel.CarImage);


            CalculateRentalDetails(carsModel, quantity);
            PickUpDate.ValueChanged += (s, e) => CalculateRentalDetails(carsModel, quantity);
            DropOffDate.ValueChanged += (s, e) => CalculateRentalDetails(carsModel, quantity);
        }

        private void CalculateRentalDetails(DisplayCarsModel carsModel, int quantity)
        {
            SubtotalLbl.Text = $"${(carsModel.Price * quantity):F2}";
            decimal rentalDays = (DropOffDate.Value.Date - PickUpDate.Value.Date).Days;
            rentalDays = rentalDays < 1 ? 1 : rentalDays;
            DailyRateLbl.Text = rentalDays > 0 ? $"${(rentalDays * carsModel.DailyRate):F2}" : $"${carsModel.DailyRate:F2}";
            TotalLbl.Text = $"${((carsModel.Price * quantity) + carsModel.Tax + (carsModel.DailyRate * rentalDays)):F2}";

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
        private void RentBtn_Click(object sender, EventArgs e)
        {
            SaveData();
            RentedCarsDB.RentedCars(rentedCarsModel);
            MessageBox.Show("RENTED SUCCESSFULLY");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void SaveData()
        {
            rentedCarsModel.Brand = BrandLbl.Text;
            rentedCarsModel.Model = ModelLbl.Text;
            rentedCarsModel.Price = decimal.Parse(PriceLbl.Text.Trim('$'));
            rentedCarsModel.Tax = decimal.Parse(TaxLbl.Text.Trim('$'));
            rentedCarsModel.DailyRate = decimal.Parse(DailyRateLbl.Text.Trim('$'));
            rentedCarsModel.Subtotal = decimal.Parse(SubtotalLbl.Text.Trim('$'));
            rentedCarsModel.Total = decimal.Parse(TotalLbl.Text.Trim('$'));
            rentedCarsModel.Seats = SeatsLbl.Text;
            rentedCarsModel.Gas = GasLbl.Text;
            rentedCarsModel.Transmission = TransmissionLbl.Text.Trim();
            rentedCarsModel.PickUpDate = PickUpDate.Value;
            rentedCarsModel.DropOffDate = DropOffDate.Value;
            rentedCarsModel.Quantity = int.Parse(QuantityLbl.Text.Trim());

            rentedCarsModel.CarImage = ConvertImageToByteArray(CarImage.Image);
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (Bitmap bmp = new Bitmap(image))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void exitModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarDetailsModal_Load(object sender, EventArgs e)
        {

        }


      
    }
}
