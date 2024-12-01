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

namespace Carl_Rental_System.Forms.User_Interface
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            DisplayProfile();
        }

        public void DisplayProfile()
        {
            string username = Register_LogInUser.LoggedInUsername;

            UserAccountModel accountModel = UserProfileDB.GetProfileByUserName(username);

            FullNameLbl.Text = accountModel.FullName;
            AgeLbl.Text = accountModel.Age.ToString();
            LocationLbl.Text = accountModel.Location;
            PhoneNumberLbl.Text = accountModel.PhoneNumber.ToString();
            EmailLbl.Text = accountModel.Email;
            UsernameLbl.Text = accountModel.Username;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
