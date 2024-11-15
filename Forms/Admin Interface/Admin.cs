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
    public partial class Admin : Form
    {
        public Admin()
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

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadform(new AdminHomeForm());
            AdminHomeForm refresh = new AdminHomeForm();
            refresh.RefreshCarData();
        }

        private void uploaCarBtn_Click(object sender, EventArgs e)
        {
            loadform(new UploadCarForm());
        }
        private void AddAdmin_Click(object sender, EventArgs e)
        {
            loadform(new AddAdminForm());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void dashboardBtn_MouseLeave(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.DarkSlateBlue;
        }

        private void dashboardBtn_MouseMove(object sender, MouseEventArgs e)
        {
            dashboardBtn.BackColor = Color.SlateBlue;
        }

        private void uploaCarBtn_MouseMove(object sender, MouseEventArgs e)
        {
            uploaCarBtn.BackColor = Color.SlateBlue;
        }

        private void uploaCarBtn_MouseLeave(object sender, EventArgs e)
        {
            uploaCarBtn.BackColor = Color.DarkSlateBlue;
        }

        private void AddAdmin_MouseLeave(object sender, EventArgs e)
        {
            AddAdmin.BackColor = Color.DarkSlateBlue;
        }

        private void AddAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            AddAdmin.BackColor = Color.SlateBlue;
        }

      
    }

}

