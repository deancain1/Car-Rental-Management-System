using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carl_Rental_System.Database
{
    public class CarsCRUD
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";


        public static void AddNewCar(CarsCRUDModel newCarModel)
        {
            try
            {
               string carQuery = "INSERT INTO Cars (Brand, Model, Price, Tax, Seats, Gas, Transmission, CarImage, Stock, DailyRate) VALUES (@Brand, @Model, @Price, @Tax, @Seats, @Gas, @Transmission, @CarImage, @Stock, @DailyRate)";
             
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand carCmd = new SqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@Brand", newCarModel.Brand);
                        carCmd.Parameters.AddWithValue("@Model", newCarModel.Model);
                        carCmd.Parameters.AddWithValue("@Price", newCarModel.Price);
                        carCmd.Parameters.AddWithValue("@Tax", newCarModel.Tax);
                        carCmd.Parameters.AddWithValue("@Seats", newCarModel.Seats);
                        carCmd.Parameters.AddWithValue("@Gas", newCarModel.Gas);
                        carCmd.Parameters.AddWithValue("@Transmission", newCarModel.Transmission);
                        carCmd.Parameters.AddWithValue("@Stock", newCarModel.Stock);
                        carCmd.Parameters.AddWithValue("@DailyRate", newCarModel.DailyRate);
                        SqlParameter CarImageParam = new SqlParameter("@CarImage", SqlDbType.VarBinary);
                        CarImageParam.Value = newCarModel.CarImage ?? (object)DBNull.Value;
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

       
        public static void UpdateCar(CarsCRUDModel newcarmodel)
        {
            string query = "UPDATE Cars SET Brand = @Brand , Model = @Model, Price= @Price,  Tax = @Tax, Seats = @Seats, Gas = @Gas,  Transmission = @Transmission, CarImage = @CarImage, Stock = @Stock, DailyRate = @DailyRate  WHERE CarID = @CarID";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", newcarmodel.CarID);
                        cmd.Parameters.AddWithValue("@Brand", newcarmodel.Brand);
                        cmd.Parameters.AddWithValue("@Model", newcarmodel.Model);
                        cmd.Parameters.AddWithValue("@Price", newcarmodel.Price);
                        cmd.Parameters.AddWithValue("@Tax", newcarmodel.Tax);
                        cmd.Parameters.AddWithValue("@Seats", newcarmodel.Seats);
                        cmd.Parameters.AddWithValue("@Gas", newcarmodel.Gas);
                        cmd.Parameters.AddWithValue("@Transmission", newcarmodel.Transmission);
                        cmd.Parameters.AddWithValue("@Stock", newcarmodel.Stock);
                        cmd.Parameters.AddWithValue("@DailyRate", newcarmodel.DailyRate);
                        SqlParameter CarImageParam = new SqlParameter("@CarImage", SqlDbType.VarBinary);
                        CarImageParam.Value = newcarmodel.CarImage ?? (object)DBNull.Value;
                        cmd.Parameters.Add(CarImageParam);

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
            }
        }
        public CarsCRUDModel GetCarDetailsById(int carId)
        {
            CarsCRUDModel carModel = null;

            string query = "SELECT CarID, Brand, Model, Price, Tax, Seats, Gas, Transmission, CarImage, Stock, DailyRate FROM Cars WHERE CarID = @CarID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CarID", carId);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                carModel = new CarsCRUDModel
                                {
                                    CarID = reader.GetInt32(reader.GetOrdinal("CarID")),
                                    Brand = reader.GetString(reader.GetOrdinal("Brand")),
                                    Model = reader.GetString(reader.GetOrdinal("Model")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    Tax = reader.GetDecimal(reader.GetOrdinal("Tax")),
                                    Seats = reader.GetString(reader.GetOrdinal("Seats")),
                                    Gas = reader.GetString(reader.GetOrdinal("Gas")),
                                    Transmission = reader.GetString(reader.GetOrdinal("Transmission")),
                                    Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                    DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
                                    CarImage = reader["CarImage"] != DBNull.Value ? (byte[])reader["CarImage"] : null
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching car details: " + ex.Message);
                    }
                }
            }

            return carModel;
        }
        public List<CarsCRUDModel> LoadCarsInDGV()
        {
            List<CarsCRUDModel> carsModels = new List<CarsCRUDModel>();

            string query = "SELECT CarID, Brand, Model, Price, Tax, Seats, Gas, Transmission, CarImage, Stock, DailyRate FROM Cars";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CarsCRUDModel carModel = new CarsCRUDModel
                                {
                                    CarID = reader.GetInt32(reader.GetOrdinal("CarID")),
                                    Brand = reader.GetString(reader.GetOrdinal("Brand")),
                                    Model = reader.GetString(reader.GetOrdinal("Model")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    Tax = reader.GetDecimal(reader.GetOrdinal("Tax")),
                                    Seats = reader.GetString(reader.GetOrdinal("Seats")),
                                    Gas = reader.GetString(reader.GetOrdinal("Gas")),
                                    Transmission = reader.GetString(reader.GetOrdinal("Transmission")),
                                    Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                    DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
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
        public void DeleteCarFromDatabase(int carId)
        {
          
            string query = "DELETE FROM Cars WHERE CarID = @CarID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Car deletion failed. No car found with the given ID.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error occurred while deleting the car: " + ex.Message);
                    }
                }
            }
        }
    }
}


