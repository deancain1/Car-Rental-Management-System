using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carl_Rental_System.Model
{
    public class DisplayCarsModel
    {

        [Key]
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public string Seats { get; set; }
        public string Gas { get; set; }
        public string Transmission { get; set; }
        public byte[] CarImage { get; set; }
        public int Availability { get; set; }


    }
}
