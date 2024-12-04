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
    public partial class ForgotPasswordAdmin : Form
    {
        private AdminAccountModel adminAccountModel;
        private AdminAccountDB db;
        public ForgotPasswordAdmin()
        {
            InitializeComponent();
            adminAccountModel = new AdminAccountModel();
            db = new AdminAccountDB();

        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxt.Text.Trim();
            string SecurityQuestion = SecurityQuestionCB.Text.Trim();
            string Answer = AnswerTxt.Text.Trim();
            string NewPassword = NewPasswordTxt.Text.Trim();


            if (
               string.IsNullOrEmpty(Username) ||

               string.IsNullOrEmpty(SecurityQuestion) ||
               string.IsNullOrEmpty(Answer) ||
               string.IsNullOrEmpty(NewPassword))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            adminAccountModel.Username = Username;
            adminAccountModel.SecurityQuestion = SecurityQuestion;
            adminAccountModel.Answer = Answer;
            adminAccountModel.Password = NewPassword;

            if (db.ChangePassword(adminAccountModel))
            {
                MessageBox.Show("Change Password Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                UsernameTxt.Text = "";
                SecurityQuestionCB.Text = "";
                AnswerTxt.Text = "";
                NewPasswordTxt.Text = "";

                AdminLoginForm Form = new AdminLoginForm();
                Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error during registration", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminLoginForm Form = new AdminLoginForm();
            Form.Show();
            this.Hide();
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {

            if (NewPasswordTxt.PasswordChar == '*')
            {
                HidePasswordBtn.BringToFront();
                NewPasswordTxt.PasswordChar = '\0';
            }
        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            if (NewPasswordTxt.PasswordChar == '\0')
            {
                ShowPasswordBtn.BringToFront();
                NewPasswordTxt.PasswordChar = '*';
            }
        }
    }
}
