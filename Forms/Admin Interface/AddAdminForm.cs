using Carl_Rental_System.Database;
using Carl_Rental_System.Forms.User_Interface;
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
    public partial class AddAdminForm : Form
    {

        private Register_LoginAdmin db;
        private AdminAccountModel accountModel;
        public AddAdminForm()
        {
            InitializeComponent();
            db = new Register_LoginAdmin();
            accountModel = new AdminAccountModel();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string FullName = FullNameTxt.Text.Trim();
            string PhoneNumber = PhoneNumberTxt.Text.Trim();
            string Email = EmailTxt.Text.Trim();
            string UserName = UserNameTxt.Text.Trim();
            string Password = PasswordTxt.Text.Trim();
            string Role = RoleTxt.Text.Trim();
            if (

               string.IsNullOrEmpty(FullName) ||
               string.IsNullOrEmpty(Email) ||
               string.IsNullOrEmpty(UserName) ||
               string.IsNullOrEmpty(Email) ||
               string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(AgeTxt.Text.Trim(), out int Age))
            {
                MessageBox.Show("Please enter a valid age", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("@gmail.com required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PhoneNumber.Length != 11 || !PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 11-digit phone number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Password.Length != 8 || !Password.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 8-digit password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.CheckUsername(UserName))
            {
                MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accountModel.FullName = FullName;
            accountModel.Age = Age;
            accountModel.PhoneNumber = PhoneNumber;
            accountModel.Email = Email;
            accountModel.Username = UserName;
            accountModel.Password = Password;
            accountModel.Role = Role;

            if (db.RegisterAccount(accountModel))
            {
                MessageBox.Show("Created Account Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FullNameTxt.Text = "";
                AgeTxt.Text = "";
                PhoneNumberTxt.Text = "";
                EmailTxt.Text = "";
                UserNameTxt.Text = "";
                PasswordTxt.Text = "";

            }
            else
            {
                MessageBox.Show("Error during registration", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FullNameTxt.Text = "";
            AgeTxt.Text = "";
            PhoneNumberTxt.Text = "";
            EmailTxt.Text = "";
            UserNameTxt.Text = "";
            PasswordTxt.Text = "";

        }

 
        private void HidePasswordBtn_Click_1(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '\0')
            {
                ShowPasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '*';
            }
        }

        private void ShowPasswordBtn_Click_1(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '*')
            {
                HidePasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '\0';
            }
        }
    }
}

