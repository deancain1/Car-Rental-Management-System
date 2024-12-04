using Carl_Rental_System.Database;
using Carl_Rental_System.Forms.User_Interface;
using Carl_Rental_System.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Carl_Rental_System.Forms
{
    public partial class RegisterAcc : Form
    {
        private UserAccountDB db;
        private UserAccountModel accountModel;

        public RegisterAcc()
        {
            InitializeComponent();
            //call the class of database
            db = new UserAccountDB();
            // call the class of model
            accountModel = new UserAccountModel();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string FullName = FullNameTxt.Text.Trim();
            string Location = LocationTxt.Text.Trim();
            string PhoneNumber = PhoneNumberTxt.Text.Trim();
            string Email = EmailTxt.Text.Trim();
            string UserName = UsernameTxt.Text.Trim();
            string SecurityQuestion = SecurityQuestionCB.Text.Trim();
            string Answer = AnswerTxt.Text.Trim();
            string Password = PasswordTxt.Text.Trim();
            string Role = RoleTxt.Text.Trim();


            if (!int.TryParse(AgeTxt.Text.Trim(), out int Age))
            {
                MessageBox.Show("Please enter a valid age", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (
                string.IsNullOrEmpty(FullName) ||
                string.IsNullOrEmpty(Location) ||
                string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(UserName) ||
                string.IsNullOrEmpty(SecurityQuestion) ||
                string.IsNullOrEmpty(Answer) ||
                string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            accountModel.Username = UserName;
            accountModel.SecurityQuestion = SecurityQuestion;
            accountModel.Answer = Answer;
            accountModel.Password = Password;
            accountModel.Role = Role;


            if (db.RegisterAccountUser(accountModel))
            {
                MessageBox.Show("Sign Up Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FullNameTxt.Text = "";
                AgeTxt.Text = "";
                LocationTxt.Text = "";
                PhoneNumberTxt.Text = "";
                EmailTxt.Text = "";
                UsernameTxt.Text = "";
                SecurityQuestionCB.Text = "";
                AnswerTxt.Text = "";
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


        private void LogInHereBtn_Click(object sender, EventArgs e)
        {
            UserLogIn userLogIn = new UserLogIn();
            userLogIn.Show();
            this.Hide();
        }
        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '*')
            {
                HidePasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '\0';
            }
        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '\0')
            {
                ShowPasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '*';
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}



