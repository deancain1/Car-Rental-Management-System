using Carl_Rental_System.Database;
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
    public partial class CarDetails : Form
    {
   
        public CarDetails()
        {
            InitializeComponent();
            
        }
        public void DisplayCarDetails(DisplayCarsModel carsModel)
        {
            CarIdLbl.Text = carsModel.CarID.ToString();
            BrandLbl.Text = carsModel.Brand;
            CarNameLbl.Text = carsModel.Model;
            PriceLbl.Text = carsModel.Price.ToString("C");
            SeatsLbl.Text = carsModel.Seats;
            GasLbl.Text = carsModel.Gas;
            TransmissionLbl.Text = carsModel.Transmission;
            CarImage.Image = ByteArrayToImage(carsModel.CarImage);

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
        private void exitModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
