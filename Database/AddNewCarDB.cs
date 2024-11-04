using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carl_Rental_System.Database
{
    public class AddNewCarDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";


        public static void AddNewCar(AddNewCarModel newCarModel)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string carQuery = "INSERT INTO Cars (Brand, Model, Price, Tax, Seats, Gas, Transmission, CarImage, Quantity) VALUES (@Brand, @Model, @Price, @Tax, @Seats, @Gas, @Transmission, @CarImage, @Quantity)";
                    using (SqlCommand carCmd = new SqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@Brand", newCarModel.Brand);
                        carCmd.Parameters.AddWithValue("@Model", newCarModel.Model);
                        carCmd.Parameters.AddWithValue("@Price", newCarModel.Price);
                        carCmd.Parameters.AddWithValue("@Tax", newCarModel.Tax);
                        carCmd.Parameters.AddWithValue("@Seats", newCarModel.Seats);
                        carCmd.Parameters.AddWithValue("@Gas", newCarModel.Gas);
                        carCmd.Parameters.AddWithValue("@Transmission", newCarModel.Transmission);
                        carCmd.Parameters.AddWithValue("@Quantity", newCarModel.Quantity);
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

       

          
  
        public static void UpdateCar(AddNewCarModel newcarmodel)
        {
            string query = "UPDATE Cars SET Brand = @Brand , Model = @Model, Price= @Price,  Tax = @Tax, Gas = @Gas, Seats = @Seats, Transmission = @Transmission Quantity = @Quantity WHERE Model = @Model";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Brand", newcarmodel.Brand);
                        cmd.Parameters.AddWithValue("@Model", newcarmodel.Model);
                        cmd.Parameters.AddWithValue("@Price", newcarmodel.Price);
                        cmd.Parameters.AddWithValue("@Tax", newcarmodel.Tax);
                        cmd.Parameters.AddWithValue("@Seats", newcarmodel.Seats);
                        cmd.Parameters.AddWithValue("@Gas", newcarmodel.Gas);
                        cmd.Parameters.AddWithValue("@Transmission", newcarmodel.Transmission);
                        cmd.Parameters.AddWithValue("@Quantity", newcarmodel.Quantity);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
            }

        }
        public void DataGridViewCars(List<AddNewCarModel> carsModels)
        {
            string query = "SELECT CarID, Brand, Model, Price, Seats, Gas, Transmission, CarImage FROM Cars";

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
                                AddNewCarModel carsModel = new AddNewCarModel();
                                carsModel.CarID = reader.GetInt32(reader.GetOrdinal("CarID"));
                                carsModel.Brand = reader["Brand"] != DBNull.Value ? reader["Brand"].ToString() : string.Empty;
                                carsModel.Model = reader["CarName"] != DBNull.Value ? reader["CarName"].ToString() : string.Empty;
                                carsModel.Price = reader["Price"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("Price")) : 0;
                                carsModel.Seats = reader["Seats"] != DBNull.Value ? reader["Seats"].ToString() : string.Empty;
                                carsModel.Gas = reader["Gas"] != DBNull.Value ? reader["Gas"].ToString() : string.Empty;
                                carsModel.Transmission = reader["Transmission"] != DBNull.Value ? reader["Transmission"].ToString() : string.Empty;
                                carsModel.CarImage = reader["CarImage"] != DBNull.Value ? (byte[])reader["CarImage"] : null;

                                carsModels.Add(carsModel);  // Add the model to the list
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
        }

    }
}

