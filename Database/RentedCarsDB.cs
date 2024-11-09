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
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string carQuery = "INSERT INTO RentedCars (Brand, Model, Price, Tax, Subtotal, Total, Seats, Gas, Transmission, CarImage, Quantity, PickUpDate, DropOffDate) VALUES (@Brand, @Model, @Price, @Tax, @Subtotal, @Total, @Seats, @Gas, @Transmission, @CarImage, @Quantity , @PickUpDate, @DropOffDate)";
                    using (SqlCommand carCmd = new SqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@Brand", rentedCars.Brand);
                        carCmd.Parameters.AddWithValue("@Model", rentedCars.Model);
                        carCmd.Parameters.AddWithValue("@Price", rentedCars.Price);
                        carCmd.Parameters.AddWithValue("@Tax", rentedCars.Tax);
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
    }
}
