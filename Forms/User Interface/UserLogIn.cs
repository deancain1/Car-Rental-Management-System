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
        private Register_LogInUser db;
        public UserLogIn()
        {
            db = new Register_LogInUser();
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameText.Text;
            string password = PasswordText.Text;

            //call the query of login
            if (db.LoginAccountUser(username, password))
            {
                UserInterfaceForm form = new UserInterfaceForm();
                form.Show();
                form.loadform(new UserHomeForm());
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_here_btn_Click_1(object sender, EventArgs e)
        {
            RegisterAcc form = new RegisterAcc();
            form.Show();
            this.Hide();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminloginBtn_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_logIn_Click(object sender, EventArgs e)
        {

        }
    }
}
