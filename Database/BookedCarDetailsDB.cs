using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Database
{
    public class BookedCarDetailsDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";


        public static void BookedCarDetails(BookedCarDetailsModel bookedCarDetails)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string carQuery = "INSERT INTO BookedCarDetails (Brand, Model, Price, Tax, Seats, Gas, Transmission, CarImage, Quantity) VALUES (@Brand, @Model, @Price, @Tax, @Seats, @Gas, @Transmission, @CarImage, @Quantity)";
                    using (SqlCommand carCmd = new SqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@Brand", bookedCarDetails.Brand);
                        carCmd.Parameters.AddWithValue("@Model", bookedCarDetails.Model);
                        carCmd.Parameters.AddWithValue("@Price", bookedCarDetails.Price);
                        carCmd.Parameters.AddWithValue("@Tax", bookedCarDetails.Tax);
                        carCmd.Parameters.AddWithValue("@Seats", bookedCarDetails.Seats);
                        carCmd.Parameters.AddWithValue("@Gas", bookedCarDetails.Gas);
                        carCmd.Parameters.AddWithValue("@Transmission", bookedCarDetails.Transmission);
                        carCmd.Parameters.AddWithValue("@Quantity", bookedCarDetails.Quantity);
                        SqlParameter CarImageParam = new SqlParameter("@CarImage", SqlDbType.VarBinary);
                        CarImageParam.Value = bookedCarDetails.CarImage ?? (object)DBNull.Value;
                        carCmd.Parameters.Add(CarImageParam);
                      
                        carCmd.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public BookedCarDetailsModel GetCarDetailsById(int carID)
        {
            var bookedcarsModel = new BookedCarDetailsModel();

            string query = "SELECT RentedCarID, Brand, Model, Price,  Tax, Seats, Gas, Transmission, CarImage FROM BookedCarDetails WHERE RentedCarID = @RentedCarID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RentedCarID", carID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())                                                                                                                                                                                                                                                                              
                            {
                                bookedcarsModel.RentedCarID = reader.GetInt32(reader.GetOrdinal("RentedCarID"));
                                bookedcarsModel.Brand = reader["Brand"] != DBNull.Value ? reader["Brand"].ToString() : string.Empty;
                                bookedcarsModel.Model = reader["Model"] != DBNull.Value ? reader["Model"].ToString() : string.Empty;
                                bookedcarsModel.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
                                bookedcarsModel.Tax = reader.GetDecimal(reader.GetOrdinal("Tax"));
                                bookedcarsModel.Seats = reader["Seats"] != DBNull.Value ? reader["Seats"].ToString() : string.Empty;
                                bookedcarsModel.Gas = reader["Gas"] != DBNull.Value ? reader["Gas"].ToString() : string.Empty;
                                bookedcarsModel.Transmission = reader["Transmission"] != DBNull.Value ? reader["Transmission"].ToString() : string.Empty;
                                bookedcarsModel.CarImage = reader["CarImage"] != DBNull.Value ? (byte[])reader["CarImage"] : null;
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        Console.WriteLine("SQL error occurred: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            } 

            return bookedcarsModel; 
        }
    }
}
