using Carl_Rental_System.Model;
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
        public bool LoginAccountUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    String query = "SELECT COUNT(1) FROM users WHERE Username = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
            string query = "SELECT COUNT (UserId) FROM users WHERE Username = @Username";
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

                    string query = "INSERT INTO users (email, Username, Password) VALUES (@Email, @Username, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", accountModel.email);
                    cmd.Parameters.AddWithValue("@Username", accountModel.username);
                    cmd.Parameters.AddWithValue("@Password", accountModel.password);

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
