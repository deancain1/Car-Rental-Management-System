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
                string username = Register_LoginAdmin.LoggedInUsername;
                AdminAccountModel accountModel = AdminProfileDB.GetProfileByUserName(username);

                string fullName = accountModel.FullName;
                string role = accountModel.Role;
                string phoneNumber = accountModel.PhoneNumber;

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();


                    string query = "INSERT INTO RentedCars (FullName, Role, PhoneNumber, Brand, Model, Price, Tax, DailyRate, Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate)VALUES (@FullName, @Role, @PhoneNumber,  @Brand, @Model, @Price, @Tax, @DailyRate, @Subtotal, @Total, @Seats, @Gas, @Transmission, @CarImage, @Quantity, @PickUpDate, @DropOffDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Brand", rentedCars.Brand);
                        cmd.Parameters.AddWithValue("@Model", rentedCars.Model);
                        cmd.Parameters.AddWithValue("@Price", rentedCars.Price);
                        cmd.Parameters.AddWithValue("@Tax", rentedCars.Tax);
                        cmd.Parameters.AddWithValue("@DailyRate", rentedCars.DailyRate);
                        cmd.Parameters.AddWithValue("@Subtotal", rentedCars.Subtotal);
                        cmd.Parameters.AddWithValue("@Total", rentedCars.Total);
                        cmd.Parameters.AddWithValue("@Seats", rentedCars.Seats);
                        cmd.Parameters.AddWithValue("@Gas", rentedCars.Gas);
                        cmd.Parameters.AddWithValue("@Transmission", rentedCars.Transmission);


                        SqlParameter CarImageParam = new SqlParameter("@CarImage", SqlDbType.VarBinary);
                        CarImageParam.Value = rentedCars.CarImage ?? (object)DBNull.Value;
                        cmd.Parameters.Add(CarImageParam);

                        cmd.Parameters.AddWithValue("@Quantity", rentedCars.Quantity);
                        cmd.Parameters.AddWithValue("@PickUpDate", rentedCars.PickUpDate);
                        cmd.Parameters.AddWithValue("@DropOffDate", rentedCars.DropOffDate);

                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateStock(DisplayCarsModel cars)
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
       
       
        public List<RentedCarsModel> LoadCarsInDGV()
        {
            List<RentedCarsModel> carsModels = new List<RentedCarsModel>();

            string query = "SELECT CarRentedID, FullName, Role, PhoneNumber, Model, Price, DailyRate, Total, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate FROM RentedCars";

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
                                RentedCarsModel carModel = new RentedCarsModel
                                {
                                    CarRentedID = reader.GetInt32(reader.GetOrdinal("CarRentedID")),
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
        public void TransferRentedCarToReturned(int CarRentedID)
        {

            RentedCarsModel rentedCarsModel = null;

            string FetchQuery = "SELECT CarRentedID, FullName, Role, PhoneNumber, Model, Price, Tax, DailyRate, Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate " +
                                "FROM RentedCars WHERE CarRentedID = @CarRentedID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(FetchQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CarRentedID", CarRentedID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentedCarsModel = new RentedCarsModel
                            {
                                CarRentedID = reader.GetInt32(reader.GetOrdinal("CarRentedID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
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
                        }
                    }
                }
            }

            string InsertQuery = "INSERT INTO ReturnedCar (FullName, Role, PhoneNumber,  Model, Price, Tax, DailyRate, " +
                                 "Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate) " +
                                 "VALUES (@FullName, @Role, @PhoneNumber, @Model, @Price, @Tax, @DailyRate, @Subtotal, @Total, " +
                                 "@Seats, @Gas, @Transmission, @CarImage, @Quantity, @PickUpDate, @DropOffDate)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(InsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", rentedCarsModel.FullName);
                    cmd.Parameters.AddWithValue("@Role", rentedCarsModel.Role);
                    cmd.Parameters.AddWithValue("@PhoneNumber", rentedCarsModel.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Model", rentedCarsModel.Model);
                    cmd.Parameters.AddWithValue("@Price", rentedCarsModel.Price);
                    cmd.Parameters.AddWithValue("@Tax", rentedCarsModel.Tax);
                    cmd.Parameters.AddWithValue("@DailyRate", rentedCarsModel.DailyRate);
                    cmd.Parameters.AddWithValue("@Subtotal", rentedCarsModel.Subtotal);
                    cmd.Parameters.AddWithValue("@Total", rentedCarsModel.Total);
                    cmd.Parameters.AddWithValue("@Seats", rentedCarsModel.Seats);
                    cmd.Parameters.AddWithValue("@Gas", rentedCarsModel.Gas);
                    cmd.Parameters.AddWithValue("@Transmission", rentedCarsModel.Transmission);
                    cmd.Parameters.AddWithValue("@CarImage", rentedCarsModel.CarImage ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Quantity", rentedCarsModel.Quantity);
                    cmd.Parameters.AddWithValue("@PickUpDate", rentedCarsModel.PickUpDate);
                    cmd.Parameters.AddWithValue("@DropOffDate", rentedCarsModel.DropOffDate);

                    cmd.ExecuteNonQuery();
                }
            }


            string DeleteQuery = "DELETE FROM RentedCars WHERE CarRentedID = @CarRentedID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(DeleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CarRentedID", CarRentedID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}