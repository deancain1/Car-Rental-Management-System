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
            //call the class of database
            db = new Register_LoginAdmin();
            InitializeComponent();
        }

        private void logIn_btn_Click_1(object sender, EventArgs e)
        {
            string username = username_logIn.Text;
            string password = password_logIn.Text;

            //call the query of login
            if (db.LoginAccount(username, password))
            {
                Admin form = new Admin();
                form.Show();
                form.loadform(new AdminHomeForm());
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_here_btn_Click(object sender, EventArgs e)
        {
            RegisterAcc form = new RegisterAcc();
            form.Show();
            this.Hide();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

