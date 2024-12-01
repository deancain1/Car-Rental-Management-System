using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carl_Rental_System.Database
{
    public class AdminProfileDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog=carRentalDB; Integrated Security=True;";

        public static AdminAccountModel GetProfileByUserName(string username)
        {
            string query = "SELECT FullName, Age,  PhoneNumber, Email, UserName, Role FROM admin WHERE UserName = @UserName";
            AdminAccountModel accountModel = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            accountModel = new AdminAccountModel
                            {
                                FullName = reader["FullName"].ToString(),
                                Age = reader.GetInt32(reader.GetOrdinal("Age")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                            };
                        }
                    }
                }
            }

            return accountModel;
        }
    }
}

