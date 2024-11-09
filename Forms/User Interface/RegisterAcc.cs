using Carl_Rental_System.Database;
using Carl_Rental_System.Forms.User_Interface;
using Carl_Rental_System.Model;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Carl_Rental_System.Forms
{
    public partial class RegisterAcc : Form
    {
        private Register_LogInUser db;
        private UserAccountModel accountModel;

        public RegisterAcc()
        {
            InitializeComponent();
            //call the class of database
            db = new Register_LogInUser();
            // call the class of model
            accountModel = new UserAccountModel();
        }
        private void signUp_btn_Click_1(object sender, EventArgs e)
        {
            string FullName = FullNameTxt.Text.Trim();
            string Location = LocationTxt.Text.Trim();
            string Email = EmailTxt.Text.Trim();
            string UserName = UserNameTxt.Text.Trim();
            string Password = PasswordTxt.Text.Trim();

          
            if (!int.TryParse(AgeTxt.Text.Trim(), out int Age))
            {
                MessageBox.Show("Please enter a valid age", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(PhoneNumberTxt.Text.Trim(), out int PhoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (
                string.IsNullOrEmpty(FullName) ||
                string.IsNullOrEmpty(Location) ||
                string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(UserName) ||
                string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if (db.CheckUsername(UserName))
            {
                MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accountModel.FullName = FullName;
            accountModel.Age = Age;
            accountModel.Location = Location;
            accountModel.PhoneNumber = PhoneNumber;
            accountModel.Email = Email;
            accountModel.UserName = UserName;
            accountModel.Password = Password;


            if (db.RegisterAccountUser(accountModel))
            {
                MessageBox.Show("Sign Up Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FullNameTxt.Text = "";
                AgeTxt.Text = "";
                LocationTxt.Text = "";
                PhoneNumberTxt.Text = "";
                EmailTxt.Text = "";
                UserNameTxt.Text = "";
                PasswordTxt.Text = "";

               
                UserLogIn form = new UserLogIn();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error during registration", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_here_btn_Click(object sender, EventArgs e)
        {
            UserLogIn userLogIn = new UserLogIn();
            userLogIn.Show();
            this.Hide();
        }
    }
}



