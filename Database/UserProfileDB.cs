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
    public class UserProfileDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog=carRentalDB; Integrated Security=True;";

        public static UserAccountModel GetProfileByUserName(string username)
        {
            string query = "SELECT FullName, Age, Location, PhoneNumber, Email, Username, Role FROM useraccount WHERE Username = @Username";
            UserAccountModel accountModel = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                accountModel = new UserAccountModel
                                {
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    Age = reader.GetInt32(reader.GetOrdinal("Age")),
                                    Location = reader.GetString(reader.GetOrdinal("Location")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                    Role = reader.GetString(reader.GetOrdinal("Role")),
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return accountModel;
        }

    }
}
