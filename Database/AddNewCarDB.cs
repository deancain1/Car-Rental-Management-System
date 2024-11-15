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

                    string carQuery = "INSERT INTO Cars (Brand, Model, Price, Tax, Seats, Gas, Transmission, CarImage, Stock, DailyRate) VALUES (@Brand, @Model, @Price, @Tax, @Seats, @Gas, @Transmission, @CarImage, @Stock, @DailyRate)";
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

       

          
  
        public static void UpdateCar(AddNewCarModel newcarmodel)
        {
            string query = "UPDATE Cars SET Brand = @Brand , Model = @Model, Price= @Price,  Tax = @Tax, Gas = @Gas, Seats = @Seats, Transmission = @Transmission Availability = @Availability WHERE Model = @Model";
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
                        cmd.Parameters.AddWithValue("@Stock", newcarmodel.Stock);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
            }
        }
      
    }
}

