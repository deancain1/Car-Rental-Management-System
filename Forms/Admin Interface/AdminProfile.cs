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
using System.Windows.Forms;

namespace Carl_Rental_System.Forms.Admin_Interface
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
            DisplayProfile();
        }
        public void DisplayProfile()
        {
            string username = AdminAccountDB.LoggedInUsername;

            AdminAccountModel accountModel = AdminProfileDB.GetProfileByUserName(username);

            FullNameLbl.Text = accountModel.FullName;
            AgeLbl.Text = accountModel.Age.ToString();
            PhoneNumberLbl.Text = accountModel.PhoneNumber.ToString();
            EmailLbl.Text = accountModel.Email;
            UsernameLbl.Text = accountModel.Username;

        }
    }
}
