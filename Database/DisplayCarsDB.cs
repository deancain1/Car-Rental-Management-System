using Carl_Rental_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Carl_Rental_System.Database
{
    public class DisplayCarsDB
    {
       private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog=carRentalDB; Integrated Security=True;";

        public static List<DisplayCarsModel> DisplayCar()
        {
            List<DisplayCarsModel> carList = new List<DisplayCarsModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT CarId, Brand, Model, Price, Tax,  Seats, Gas, Transmission, CarImage,  Stock, DailyRate FROM Cars";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())  
                        {
                            while (reader.Read())
                            {
                                var car = new DisplayCarsModel
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

                                carList.Add(car);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return carList;
        }


        public static List<DisplayCarsModel> DisplayCarBrand(string brand) 
        {
            List<DisplayCarsModel> carList = new List<DisplayCarsModel>();

            try
            {
                string query = "SELECT CarID, Brand, Model, Price, Seats,  Tax, Gas, Transmission,  CarImage , Stock, DailyRate  FROM Cars WHERE Brand = @Brand";

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", brand);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var car = new DisplayCarsModel
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

                                carList.Add(car);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return carList;
        }

        public DisplayCarsModel GetCarDetailsById(int carID)
        {
            var carsModel = new DisplayCarsModel();

            string query = "SELECT CarID, Brand, Model, Price,  Tax, Seats, Gas, Transmission, CarImage, DailyRate FROM Cars WHERE CarID = @CarID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CarID", carID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                carsModel.CarID = reader.GetInt32(reader.GetOrdinal("CarID"));
                                carsModel.Brand = reader.GetString(reader.GetOrdinal("Brand"));
                                carsModel.Model = reader.GetString(reader.GetOrdinal("Model"));
                                carsModel.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
                                carsModel.Tax = reader.GetDecimal(reader.GetOrdinal("Tax"));
                                carsModel.Seats = reader.GetString(reader.GetOrdinal("Seats"));
                                carsModel.Gas = reader.GetString(reader.GetOrdinal("Gas"));
                                carsModel.Transmission = reader.GetString(reader.GetOrdinal("Transmission"));
                                carsModel.DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate"));
                                carsModel.CarImage = (byte[])reader["CarImage"];
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

           return carsModel; 
        }
    }
}


    