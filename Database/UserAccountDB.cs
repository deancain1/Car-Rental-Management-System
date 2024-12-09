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
    public class UserAccountDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";

        public static string LoggedInUsername { get; private set; }

        public bool LoginAccountUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM useraccount WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

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
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
     
        }

        public bool CheckUsername(string Username)
        {
            string query = "SELECT COUNT(userID) FROM useraccount WHERE Username = @Username";

            try
            {
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
            catch (SqlException ex)
            {
             
                MessageBox.Show("SQL error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
      
        }

        public bool RegisterAccountUser(UserAccountModel accountModel)
        {
            string query = "INSERT INTO useraccount (FullName, Age, Location, PhoneNumber, Email, Username, SecurityQuestion, Answer, Password, Role) VALUES ( @FullName, @Age, @Location, @PhoneNumber, @Email, @Username, @SecurityQuestion, @Answer, @Password, @Role)";
          
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                   
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", accountModel.FullName);
                    cmd.Parameters.AddWithValue("@Age", accountModel.Age);
                    cmd.Parameters.AddWithValue("@Location", accountModel.Location);
                    cmd.Parameters.AddWithValue("@PhoneNumber", accountModel.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", accountModel.Email);
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

                MessageBox.Show("SQL Error: " + sqlEx.Message);
                return false;
            }
        }
        public bool ChangePassword(UserAccountModel userAccountModel)
        {
            string FetchQuery = "SELECT COUNT(1) FROM useraccount WHERE Username = @Username AND SecurityQuestion = @SecurityQuestion AND Answer = @Answer";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand checkCmd = new SqlCommand(FetchQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Username", userAccountModel.Username);
                    checkCmd.Parameters.AddWithValue("@SecurityQuestion", userAccountModel.SecurityQuestion);
                    checkCmd.Parameters.AddWithValue("@Answer", userAccountModel.Answer);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        string UpdateQuery = "UPDATE useraccount SET Password = @Password WHERE Username = @Username";
                        SqlCommand updateCmd = new SqlCommand(UpdateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Username", userAccountModel.Username);
                        updateCmd.Parameters.AddWithValue("@Password", userAccountModel.Password);

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
