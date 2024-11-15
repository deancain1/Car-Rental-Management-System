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
    public class RentedCarsDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";
        public static void RentedCars(RentedCarsModel rentedCars)
        {
            try
            {
                string username = Register_LogInUser.LoggedInUsername;
                UserAccountModel accountModel = UserProfileDB.GetProfileByUserName(username);

                string fullName = accountModel.FullName;
                string phoneNumber = accountModel.PhoneNumber.ToString();

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                   
                    string carQuery = @"INSERT INTO RentedCars (FullName, PhoneNumber, Brand, Model, Price, Tax, DailyRate, Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate)VALUES (@FullName, @PhoneNumber, @Brand, @Model, @Price, @Tax, @DailyRate, @Subtotal, @Total, @Seats, @Gas, @Transmission, @CarImage, @Quantity, @PickUpDate, @DropOffDate)";

                    using (SqlCommand carCmd = new SqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@FullName", fullName);
                        carCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        carCmd.Parameters.AddWithValue("@Brand", rentedCars.Brand);
                        carCmd.Parameters.AddWithValue("@Model", rentedCars.Model);
                        carCmd.Parameters.AddWithValue("@Price", rentedCars.Price);
                        carCmd.Parameters.AddWithValue("@Tax", rentedCars.Tax);
                        carCmd.Parameters.AddWithValue("@DailyRate", rentedCars.DailyRate);
                        carCmd.Parameters.AddWithValue("@Subtotal", rentedCars.Subtotal);
                        carCmd.Parameters.AddWithValue("@Total", rentedCars.Total);
                        carCmd.Parameters.AddWithValue("@Seats", rentedCars.Seats);
                        carCmd.Parameters.AddWithValue("@Gas", rentedCars.Gas);
                        carCmd.Parameters.AddWithValue("@Transmission", rentedCars.Transmission);

                     
                        SqlParameter CarImageParam = new SqlParameter("@CarImage", SqlDbType.VarBinary);
                        CarImageParam.Value = rentedCars.CarImage ?? (object)DBNull.Value;
                        carCmd.Parameters.Add(CarImageParam);

                        carCmd.Parameters.AddWithValue("@Quantity", rentedCars.Quantity);
                        carCmd.Parameters.AddWithValue("@PickUpDate", rentedCars.PickUpDate);
                        carCmd.Parameters.AddWithValue("@DropOffDate", rentedCars.DropOffDate);

                        carCmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public  void UpdateStock(DisplayCarsModel cars)
        {
            string query = "UPDATE Cars SET Stock = @Stock WHERE CarID = @CarID"; ;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@CarID", cars.CarID);
                        cmd.Parameters.AddWithValue("@Stock", cars.Stock);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
            }
        }
        public static List<RentedCarsModel> LoadRentedCar()
        {
            List<RentedCarsModel> carList = new List<RentedCarsModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT FullName, Brand, Model, Price, Tax, DailyRate, Subtotal, Total,   Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate  FROM RentedCars";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var car = new RentedCarsModel
                                {
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    Brand = reader.GetString(reader.GetOrdinal("Brand")),
                                    Model = reader.GetString(reader.GetOrdinal("Model")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    Tax = reader.GetDecimal(reader.GetOrdinal("Tax")),
                                    DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
                                    Subtotal = reader.GetDecimal(reader.GetOrdinal("Subtotal")),
                                    Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                                    Seats = reader.GetString(reader.GetOrdinal("Seats")),
                                    Gas = reader.GetString(reader.GetOrdinal("Gas")),
                                    Transmission = reader.GetString(reader.GetOrdinal("Transmission")),
                                    CarImage = (byte[])reader["CarImage"],
                                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                    PickUpDate = reader.GetDateTime(reader.GetOrdinal("PickUpDate")), 
                                    DropOffDate = reader.GetDateTime(reader.GetOrdinal("DropOffDate"))


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

    }
}
