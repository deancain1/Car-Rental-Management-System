using System.ComponentModel.DataAnnotations;

namespace Carl_Rental_System.Model
{
    public class AccountModel
    {

        [Key]
        public int adminId { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
