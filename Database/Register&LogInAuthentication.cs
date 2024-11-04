using Carl_Rental_System.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Carl_Rental_System.Database
{
    public class Register_LogInAuthentication
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";
        public bool LoginAccount(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    String query = "SELECT COUNT(1) FROM admin WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

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
            string query = "SELECT COUNT (adminId) FROM admin WHERE username = @username";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", Username);

                    int count = (int)cmd.ExecuteScalar();
                    return count >= 1;
                }
            }
        }
        public bool RegisterAccount(AccountModel accountModel)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO admin (email, username, password) VALUES (@Email, @Username, @Password)";
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
                // Log the SQL exception
                Console.WriteLine("SQL Error: " + sqlEx.Message);
                return false;
            }
        }


    }
}
