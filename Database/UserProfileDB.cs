using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carl_Rental_System.Database
{
    public class UserProfileDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog=carRentalDB; Integrated Security=True;";

        public static UserAccountModel GetProfileByUserName(string username)
        {
            string query = "SELECT FullName, Age, Location, PhoneNumber, Email, Username FROM useraccount WHERE Username = @Username";
            UserAccountModel accountModel = null;

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
                                FullName = reader["FullName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                Location = reader["Location"].ToString(),
                                PhoneNumber = Convert.ToInt32(reader["PhoneNumber"]),
                                Email = reader["Email"].ToString(),
                                UserName = reader["Username"].ToString()
                            };
                        }
                    }
                }
            }

            return accountModel;
        }

    }
}
