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
    public class AdminAccountDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";
        public static string LoggedInUsername { get; private set; }
        public bool LoginAccount(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM admin WHERE UserName = @UserName AND Password = @Password";

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", username);
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
        public bool CheckUsername(string Username)
        {
            string query = "SELECT COUNT (adminId) FROM admin WHERE UserName = @UserName";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", Username);

                    int count = (int)cmd.ExecuteScalar();
                    return count >= 1;
                }
            }
        }
        public bool RegisterAccount(AdminAccountModel accountModel)
        {
            string query = "INSERT INTO admin (FullName, Age, Email, PhoneNumber, UserName,  SecurityQuestion, Answer, Password, Role) VALUES (@FullName, @Age, @Email, @PhoneNumber, @Username, @SecurityQuestion, @Answer, @Password, @Role)";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FullName", accountModel.FullName);
                    cmd.Parameters.AddWithValue("@Age", accountModel.Age);
                    cmd.Parameters.AddWithValue("@Email", accountModel.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", accountModel.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Username", accountModel.Username);
                    cmd.Parameters.AddWithValue("@SecurityQuestion", accountModel.SecurityQuestion);
                    cmd.Parameters.AddWithValue("@Answer", accountModel.Answer);
                    cmd.Parameters.AddWithValue("@Password", accountModel.Password);
                    cmd.Parameters.AddWithValue("@Role", accountModel.Role);
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
        public bool ChangePassword(AdminAccountModel adminAccountModel)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();


                    string FetchQuery = "SELECT COUNT(1) FROM admin WHERE Username = @Username AND SecurityQuestion = @SecurityQuestion AND Answer = @Answer";
                    SqlCommand checkCmd = new SqlCommand(FetchQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Username", adminAccountModel.Username);
                    checkCmd.Parameters.AddWithValue("@SecurityQuestion", adminAccountModel.SecurityQuestion);
                    checkCmd.Parameters.AddWithValue("@Answer", adminAccountModel.Answer);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        string UpdateQuery = "UPDATE admin SET Password = @Password WHERE Username = @Username";
                        SqlCommand updateCmd = new SqlCommand(UpdateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Username", adminAccountModel.Username);
                        updateCmd.Parameters.AddWithValue("@Password", adminAccountModel.Password);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        return rowsAffected > 0;

                    }
                    else
                    {
                        MessageBox.Show("Failed to change password.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
