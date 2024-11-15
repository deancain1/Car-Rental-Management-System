using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carl_Rental_System.Model
{
    public class RentedCarsModel
    {

        public int CarRentedID { get; set; }
        public string FullName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal DailyRate { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string Seats { get; set; }
        public string Gas { get; set; }
        public string Transmission { get; set; }
        public byte[] CarImage { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int Quantity { get; set; }
        public UserAccountModel Renter { get; set; }
    }
}
