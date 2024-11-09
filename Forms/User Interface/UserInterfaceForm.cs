using Carl_Rental_System.Forms.Admin_Interface;
using ComponentFactory.Krypton.Toolkit;
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
    public partial class UserInterfaceForm : Form
    {
        public UserInterfaceForm()
        {
           
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            loadform(new UserHomeForm());
        }

        private void CarBtn_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.RefreshCarDetails();
            loadform(new CarsForm());
        }
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            loadform(new UserProfile());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            UserLogIn userLogIn = new UserLogIn();
            userLogIn.Show();
            this.Hide();
        }

        private void HoverBtn()
        {
            
        }
        private void LogoutBtn_MouseMove(object sender, MouseEventArgs e)
        {
            LogoutBtn.BackColor = Color.SlateBlue;

        }

        private void LogoutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.DarkSlateBlue;
        }

    
        private void CartBtn_MouseMove(object sender, MouseEventArgs e)
        {
            ProfileBtn.BackColor = Color.SlateBlue;
        }

        private void CartBtn_MouseLeave(object sender, EventArgs e)
        {
            ProfileBtn.BackColor = Color.DarkSlateBlue;
        }

        private void CarBtn_MouseMove(object sender, MouseEventArgs e)
        {
           CarBtn.BackColor = Color.SlateBlue;
        }

        private void CarBtn_MouseLeave(object sender, EventArgs e)
        {
            CarBtn.BackColor = Color.DarkSlateBlue;
        }

        private void HomeBtn_MouseMove(object sender, MouseEventArgs e)
        {
            HomeBtn.BackColor = Color.SlateBlue;
        }

        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
           HomeBtn.BackColor = Color.DarkSlateBlue;
        }
    }
}
