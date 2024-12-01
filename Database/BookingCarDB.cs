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
    public class BookingCarDB
    {
        private static string ConnectionString = @"Data Source=LAPTOP-S6PGLPQ2;Initial Catalog = carRentalDB; Integrated Security = True;";
        public static void BookingCar(BookingModel bookingModel)
        {
            try
            {
                string username = Register_LogInUser.LoggedInUsername;
                UserAccountModel accountModel = UserProfileDB.GetProfileByUserName(username);

                string fullName = accountModel.FullName;
                string role = accountModel.Role;
                string phoneNumber = accountModel.PhoneNumber.ToString();

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();


                    string carQuery = "INSERT INTO Booking (FullName, Role, PhoneNumber, Brand, Model, Price, Tax, DailyRate, Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate)VALUES (@FullName, @Role, @PhoneNumber, @Brand, @Model, @Price, @Tax, @DailyRate, @Subtotal, @Total, @Seats, @Gas, @Transmission, @CarImage, @Quantity, @PickUpDate, @DropOffDate)";

                    using (SqlCommand carCmd = new SqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@FullName", fullName);
                        carCmd.Parameters.AddWithValue("@Role", role);
                        carCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        carCmd.Parameters.AddWithValue("@Brand", bookingModel.Brand);
                        carCmd.Parameters.AddWithValue("@Model", bookingModel.Model);
                        carCmd.Parameters.AddWithValue("@Price", bookingModel.Price);
                        carCmd.Parameters.AddWithValue("@Tax", bookingModel.Tax);
                        carCmd.Parameters.AddWithValue("@DailyRate", bookingModel.DailyRate);
                        carCmd.Parameters.AddWithValue("@Subtotal", bookingModel.Subtotal);
                        carCmd.Parameters.AddWithValue("@Total", bookingModel.Total);
                        carCmd.Parameters.AddWithValue("@Seats", bookingModel.Seats);
                        carCmd.Parameters.AddWithValue("@Gas", bookingModel.Gas);
                        carCmd.Parameters.AddWithValue("@Transmission", bookingModel.Transmission);


                        SqlParameter CarImageParam = new SqlParameter("@CarImage", SqlDbType.VarBinary);
                        CarImageParam.Value = bookingModel.CarImage ?? (object)DBNull.Value;
                        carCmd.Parameters.Add(CarImageParam);

                        carCmd.Parameters.AddWithValue("@Quantity", bookingModel.Quantity);
                        carCmd.Parameters.AddWithValue("@PickUpDate", bookingModel.PickUpDate);
                        carCmd.Parameters.AddWithValue("@DropOffDate", bookingModel.DropOffDate);

                        carCmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<BookingModel> LoadRentedCar()
        {
            List<BookingModel> carList = new List<BookingModel>();
            try
            {
                string username = Register_LogInUser.LoggedInUsername;
                UserAccountModel accountModel = UserProfileDB.GetProfileByUserName(username);
                string fullName = accountModel.FullName;

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT FullName, BookCarID, Brand, Model, Price, Tax, DailyRate, Subtotal, Total, " +
                                     "Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate " +
                                     "FROM Booking WHERE FullName = @FullName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var car = new BookingModel
                                {
                                    BookCarID = reader.GetInt32(reader.GetOrdinal("BookCarID")),
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
        public bool DeleteRentedCar(int carRentedID)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Booking WHERE BookCarID = @BookCarID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCarID", carRentedID);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<BookingModel> LoadCarsInDGV()
        {
            List<BookingModel> carsModels = new List<BookingModel>();

            string query = "SELECT BookCarID,  FullName, Role, PhoneNumber, Model, Price, DailyRate, Total, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate FROM Booking";

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
                                BookingModel carModel = new BookingModel
                                {
                                    BookCarID = reader.GetInt32(reader.GetOrdinal("BookCarID")),
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
        public void TransferDataToRentedCar(int BookCarID)
        {
            BookingModel bookingModel = null;

            string FetchQuery = "SELECT BookCarID, FullName, Role, PhoneNumber, Model, Price, Tax, DailyRate, Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate " +
                                "FROM Booking WHERE BookCarID = @BookCarID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(FetchQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@BookCarID", BookCarID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bookingModel = new BookingModel
                            {
                                BookCarID = reader.GetInt32(reader.GetOrdinal("BookCarID")),
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

            string InsertQuery = "INSERT INTO RentedCars (FullName, Role, PhoneNumber, Model, Price, Tax, DailyRate, " +
                                 "Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate) " +
                                 "VALUES (@FullName, @Role, @PhoneNumber, @Model, @Price, @Tax, @DailyRate, @Subtotal, @Total, " +
                                 "@Seats, @Gas, @Transmission, @CarImage, @Quantity, @PickUpDate, @DropOffDate)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(InsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", bookingModel.FullName);
                    cmd.Parameters.AddWithValue("@Role", bookingModel.Role);
                    cmd.Parameters.AddWithValue("@PhoneNumber", bookingModel.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Model", bookingModel.Model);
                    cmd.Parameters.AddWithValue("@Price", bookingModel.Price);
                    cmd.Parameters.AddWithValue("@Tax", bookingModel.Tax);
                    cmd.Parameters.AddWithValue("@DailyRate", bookingModel.DailyRate);
                    cmd.Parameters.AddWithValue("@Subtotal", bookingModel.Subtotal);
                    cmd.Parameters.AddWithValue("@Total", bookingModel.Total);
                    cmd.Parameters.AddWithValue("@Seats", bookingModel.Seats);
                    cmd.Parameters.AddWithValue("@Gas", bookingModel.Gas);
                    cmd.Parameters.AddWithValue("@Transmission", bookingModel.Transmission);
                    cmd.Parameters.AddWithValue("@CarImage", bookingModel.CarImage ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Quantity", bookingModel.Quantity);
                    cmd.Parameters.AddWithValue("@PickUpDate", bookingModel.PickUpDate);
                    cmd.Parameters.AddWithValue("@DropOffDate", bookingModel.DropOffDate);

                    cmd.ExecuteNonQuery();
                }
            }

  
            string UpdateStock = "UPDATE Cars SET Stock = Stock - @Quantity WHERE Model = @Model";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(UpdateStock, conn))
                {
                    cmd.Parameters.AddWithValue("@Quantity", bookingModel.Quantity);
                    cmd.Parameters.AddWithValue("@Model", bookingModel.Model);

                    cmd.ExecuteNonQuery();
                }
            }

           
            string DeleteQuery = "DELETE FROM Booking WHERE BookCarID = @BookCarID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(DeleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@BookCarID", BookCarID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Booking transferred to RentedCars successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
