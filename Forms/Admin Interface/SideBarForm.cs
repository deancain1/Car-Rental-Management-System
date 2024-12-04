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
    public partial class SideBarForm : Form
    {
        public SideBarForm()
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
        
        }

        private void uploaCarBtn_Click(object sender, EventArgs e)
        {
            loadform(new UploadCarForm());
        }
        
        private void AddAcountBtn_Click(object sender, EventArgs e)
        {
            loadform(new AddAdminForm());
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            loadform(new AdminProfile());
        }
        private void BookedCarBtn_Click(object sender, EventArgs e)
        {
            loadform(new BookedCarForm());
        }

        private void RentedCarBtn_Click(object sender, EventArgs e)
        {
            loadform(new RentedCarForm());
        }
        private void ReturnCarBtn_Click(object sender, EventArgs e)
        {
            loadform(new ReturnCarForm());
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            AdminLoginForm logInForm = new AdminLoginForm();
            logInForm.Show();
            this.Hide();
        }



        bool settingExpand = false;
        private void SettingTransition_Tick(object sender, EventArgs e)
        {
          
            if (settingExpand == false)
            {
              
                SettingContainer.Height += 95;
                if (SettingContainer.Height >= 200)
                {
                    SettingContainer.Height = 200; 
                    SettingTransition.Stop();
                    settingExpand = true;
                }
            }
            else
            {
                
                SettingContainer.Height -= 95;
                if (SettingContainer.Height <= 55)
                {
                    SettingContainer.Height = 55; 
                    SettingTransition.Stop();
                    settingExpand = false;
                }
            }
        }

  
        private void SettingsBtn_Click_1(object sender, EventArgs e)
        {
            SettingTransition.Start();
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
        private void SettingsBtn_MouseMove(object sender, MouseEventArgs e)
        {
            SettingsBtn.BackColor = Color.SlateBlue;
        }
        private void SettingsBtn_MouseLeave(object sender, EventArgs e)
        {
            SettingsBtn.BackColor = Color.DarkSlateBlue;
        }
        private void BookedCarBtn_MouseMove(object sender, MouseEventArgs e)
        {
            BookedCarBtn.BackColor = Color.SlateBlue;
        }

        private void BookedCarBtn_MouseLeave(object sender, EventArgs e)
        {
            BookedCarBtn.BackColor = Color.DarkSlateBlue;
        }

        private void RentedCarBtn_MouseMove(object sender, MouseEventArgs e)
        {
            RentedCarBtn.BackColor = Color.SlateBlue;
        }

        private void RentedCarBtn_MouseLeave(object sender, EventArgs e)
        {
            RentedCarBtn.BackColor = Color.DarkSlateBlue;
        }

        private void ReturnCarBtn_MouseMove(object sender, MouseEventArgs e)
        {
            ReturnCarBtn.BackColor = Color.SlateBlue;
        }

        private void ReturnCarBtn_MouseLeave(object sender, EventArgs e)
        {

            ReturnCarBtn.BackColor = Color.DarkSlateBlue;
        }
    }
}

