﻿using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Database
{
    public class Register_LogInUser
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";
   
            public static string LoggedInUsername { get; private set; }
            public bool LoginAccountUser(string username, string password)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        string query = "SELECT COUNT(1) FROM useraccount WHERE Username = @Username AND Password = @Password";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                           
                            LoggedInUsername = username;
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }


            public bool CheckUsername(string Username)
            {
                string query = "SELECT COUNT (UserId) FROM useraccount WHERE Username = @Username";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);

                        int count = (int)cmd.ExecuteScalar();
                        return count >= 1;
                    }
                }
            }
            public bool RegisterAccountUser(UserAccountModel accountModel)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO useraccount (FullName, Age, Location, PhoneNumber, Email, Username, Password) VALUES ( @FullName, @Age, @Location, @PhoneNumber, @Email, @Username, @Password)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@FullName", accountModel.FullName);
                        cmd.Parameters.AddWithValue("@Age", accountModel.Age);
                        cmd.Parameters.AddWithValue("@Location", accountModel.Location);
                        cmd.Parameters.AddWithValue("@PhoneNumber", accountModel.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Email", accountModel.Email);
                        cmd.Parameters.AddWithValue("@Username", accountModel.UserName);
                        cmd.Parameters.AddWithValue("@Password", accountModel.Password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException sqlEx)
                {

                    Console.WriteLine("SQL Error: " + sqlEx.Message);
                    return false;
                }
            }

        }
    } 
