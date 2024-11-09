using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carl_Rental_System.Model
{
    public class UserAccountModel
    {
        [Key]
        public int userID { get; set; }
        public string FullName { get; set; }
        public int  Age { get; set; }
        public string Location { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
