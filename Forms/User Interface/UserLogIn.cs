using Carl_Rental_System.Database;
using Carl_Rental_System.Forms.Admin_Interface;
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
    public partial class UserLogIn : Form
    {
        private UserAccountDB db;
        public UserLogIn()
        {
            db = new UserAccountDB();
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

 
            if (db.LoginAccountUser(username, password))
            {
                NavigationBarForm form = new NavigationBarForm();
                form.Show();
                form.loadform(new UserHomeForm());
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterHereBtn_Click(object sender, EventArgs e)
        {
            RegisterAcc form = new RegisterAcc();
            form.Show();
            this.Hide();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogInBtn_Click_1(object sender, EventArgs e)
        {
            AdminLoginForm login = new AdminLoginForm();
            login.Show();
            this.Hide();
        }

        private void ShowPasswordBtn_Click_1(object sender, EventArgs e)
        {

            if (PasswordTxt.PasswordChar == '*')
            {
                HidePasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '\0';
            }
        }

        private void HidePasswordBtn_Click_1(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '\0')
            {
                ShowPasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '*';
            }
        }

        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm ForgotPassword = new ForgotPasswordForm();
            ForgotPassword.Show();
            this.Hide();
        }
    }
}
