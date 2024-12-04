using Carl_Rental_System.Database;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Carl_Rental_System.Forms.User_Interface
{
    public partial class ForgotPasswordForm : Form
    {
        private UserAccountModel accountModel;
        private UserAccountDB db;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            accountModel = new UserAccountModel();
            db = new UserAccountDB();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            accountModel.Username = Username;
            accountModel.SecurityQuestion = SecurityQuestion;
            accountModel.Answer = Answer;
            accountModel.Password = NewPassword;

            if (db.ChangePassword(accountModel))
            {
                MessageBox.Show("Change Password Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                UsernameTxt.Text = "";
                SecurityQuestionCB.Text = "";
                AnswerTxt.Text = "";
                NewPasswordTxt.Text = "";
     
                UserLogIn form = new UserLogIn();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error during registration", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserLogIn form = new UserLogIn();
            form.Show();
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
