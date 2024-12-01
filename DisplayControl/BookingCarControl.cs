using Carl_Rental_System.Database;
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

namespace Carl_Rental_System.DisplayControl
{
    public partial class BookingCarControl : UserControl
    {
        private BookingModel bookingModel;
        public event EventHandler CarDeleted;
        public BookingCarControl(BookingModel bookCar)
        {
            this.bookingModel = bookCar;
            InitializeComponent();
            InitializeCarDetails();
         
        }
        private void InitializeCarDetails()
        {
          
                    BookCarIDLbl.Text = bookingModel.BookCarID.ToString();
                    BrandLbl.Text = bookingModel.Brand;
                    ModelLbl.Text = bookingModel.Model;
                    PriceLbl.Text = $"${bookingModel.Price:F2}";
                    TaxLbl.Text = $"${bookingModel.Tax:F2}";
                    SubtotalLbl.Text = $"${bookingModel.Subtotal:F2}";
                    DailyRateLbl.Text = $"${bookingModel.DailyRate:F2}";
                    TotalLbl.Text = $"${bookingModel.Total:F2}";
                    SeatsLbl.Text = bookingModel.Seats;
                    GasLbl.Text = bookingModel.Gas;
                    TransmissionLbl.Text = bookingModel.Transmission;
                    QuantityLbl.Text = bookingModel.Quantity.ToString();
                    CarImage.Image = ByteArrayToImage(bookingModel.CarImage);
                    PickUpDateLbl.Text = bookingModel.PickUpDate.ToString("MMMM dd, yyyy");
                    DropOffDateLbl.Text = bookingModel.DropOffDate.ToString("MMMM dd, yyyy");
                
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (bookingModel.BookCarID > 0)
            {

                var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);     

                if (result == DialogResult.Yes)
                {
                    BookingCarDB db = new BookingCarDB();
                    bool success = db.DeleteRentedCar(bookingModel.BookCarID);

                    if (success)
                    {

                        MessageBox.Show("Book has been successfully canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarDeleted?.Invoke(this, EventArgs.Empty);
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel booking. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

