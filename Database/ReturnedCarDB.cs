using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carl_Rental_System.Database
{
    public class ReturnedCarDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";
        public List<ReturnedCarModel> LoadCarsInDGV()
        {
            List<ReturnedCarModel> carsModels = new List<ReturnedCarModel>();

            string query = "SELECT ReturnedCarID,  FullName, Role, PhoneNumber, Model, Price, DailyRate, Total, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate FROM ReturnedCar";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ReturnedCarModel carModel = new ReturnedCarModel
                                {
                                    ReturnedCarID = reader.GetInt32(reader.GetOrdinal("ReturnedCarID")),
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    Role = reader.GetString(reader.GetOrdinal("Role")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    Model = reader.GetString(reader.GetOrdinal("Model")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
                                    Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                                    Gas = reader.GetString(reader.GetOrdinal("Gas")),
                                    Transmission = reader.GetString(reader.GetOrdinal("Transmission")),
                                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                    PickUpDate = reader.GetDateTime(reader.GetOrdinal("PickUpDate")),
                                    DropOffDate = reader.GetDateTime(reader.GetOrdinal("DropOffDate")),
                                    CarImage = (byte[])reader["CarImage"]

                                };

                                carsModels.Add(carModel);
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

            return carsModels;
        }
    }
}
