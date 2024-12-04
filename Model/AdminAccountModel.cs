using System.ComponentModel.DataAnnotations;

namespace Carl_Rental_System.Model
{
    public class AdminAccountModel
    {

        [Key]
        public int adminID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string SecurityQuestion { get; set; }
        public string Answer { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
