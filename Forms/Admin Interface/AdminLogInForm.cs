using Carl_Rental_System.Database;
using Carl_Rental_System.Forms;
using Carl_Rental_System.Forms.Admin_Interface;
using Carl_Rental_System.Forms.User_Interface;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
namespace Carl_Rental_System
{
    public partial class LogInForm : KryptonForm
    {
        private Register_LoginAdmin db;


        public LogInForm()
        {

            db = new Register_LoginAdmin();
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

    
            if (db.LoginAccount(username, password))
            {
                SideBarForm form = new SideBarForm();
                form.Show();
                form.loadform(new AdminHomeForm());
              

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserLogIn form = new UserLogIn();
            form.Show();
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
    }
}

