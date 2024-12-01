﻿using Carl_Rental_System.Database;
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
    public partial class AddAdminForm : Form
    {

        private Register_LoginAdmin db;
        private AdminAccountModel accountModel;
        public AddAdminForm()
        {
            InitializeComponent();
            //call the class of database
            db = new Register_LoginAdmin();
            // call the class of model
            accountModel = new AdminAccountModel();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string FullName = FullNameTxt.Text.Trim();
            string Age = AgeTxt.Text.Trim();
            string PhoneNumber = PhoneNumberTxt.Text.Trim();
            string Email = EmailTxt.Text.Trim();
            string UserName = UserNameTxt.Text.Trim();
            string Password = PasswordTxt.Text.Trim();

            if (
                string.IsNullOrEmpty(FullName) ||
                string.IsNullOrEmpty(Age) ||
                string.IsNullOrEmpty(PhoneNumber) ||
                string.IsNullOrEmpty(UserName) ||
                string.IsNullOrEmpty(Email) || 
                string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.CheckUsername(UserName))
            {
                MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accountModel.FullName = FullName;
            accountModel.Age = Age;
            accountModel.PhoneNumber = PhoneNumber;
            accountModel.Email = Email;
            accountModel.UserName = UserName;
            accountModel.Password = Password;

            // call the query of signup
            if (db.RegisterAccount(accountModel))
            {
                MessageBox.Show("Created Account Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FullNameTxt.Text = "";
                AgeTxt.Text = "";
                PhoneNumberTxt.Text = "";
                EmailTxt.Text = "";
                UserNameTxt.Text = "";
                PasswordTxt.Text = "";

            }
            else
            {
                MessageBox.Show("Error during registration", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}