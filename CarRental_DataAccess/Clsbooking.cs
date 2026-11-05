using CarRental_DataAccess.DTO;
using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental_DataAccess
{
    public class Clsbooking
    {
          
            public static List<clsBookingDTO> GetAllBookings()
            {
                var BookingsList = new List<clsBookingDTO>();

                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllBookings", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            string? InitialCheckNotes = reader["InitialCheckNotes"] != DBNull.Value
                             ? reader.GetString(reader.GetOrdinal("InitialCheckNotes"))
                             : "";

                            BookingsList.Add(new clsBookingDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("BookingID")),
                                    reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                    reader.GetInt32(reader.GetOrdinal("VehicleID")),
                                    reader.GetDateTime(reader.GetOrdinal("RentalStartDate")),
                                     reader.GetDateTime(reader.GetOrdinal("RentalEndDate")),
                                    reader.GetString(reader.GetOrdinal("PickupLocation")),
                                    reader.GetString(reader.GetOrdinal("DropoffLocation")),
                                    reader.GetByte(reader.GetOrdinal("InitialRentalDays")),
                                reader.GetDecimal(reader.GetOrdinal("RentalPricePerDay")),
                                reader.GetDecimal(reader.GetOrdinal("InitialTotalDueAmount")),
                             InitialCheckNotes
                                ));
                            }
                        }
                    }


                    return BookingsList;
                }

            }




        public static clsBookingDTO GetBookingById(int bookingId)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetBookingByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", bookingId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string? InitialCheckNotes = reader["InitialCheckNotes"] != DBNull.Value
                          ? reader.GetString(reader.GetOrdinal("InitialCheckNotes"))
                          : "";

                        return new clsBookingDTO
                        (
                            reader.GetInt32(reader.GetOrdinal("BookingID")),
                            reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            reader.GetInt32(reader.GetOrdinal("VehicleID")),
                            reader.GetDateTime(reader.GetOrdinal("RentalStartDate")),
                            reader.GetDateTime(reader.GetOrdinal("RentalEndDate")),
                            reader.GetString(reader.GetOrdinal("PickupLocation")),
                            reader.GetString(reader.GetOrdinal("DropoffLocation")),
                            reader.GetByte(reader.GetOrdinal("InitialRentalDays")),
                            reader.GetDecimal(reader.GetOrdinal("RentalPricePerDay")),
                            reader.GetDecimal(reader.GetOrdinal("InitialTotalDueAmount")),
                           InitialCheckNotes
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }






            public static int AddBooking(clsBookingDTO Booking)
            {
            int outputId = -1;
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_AddNewBooking", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CustomerID", Booking.CustomerId);
                command.Parameters.AddWithValue("@VehicleID", Booking.VehicleId);
                command.Parameters.AddWithValue("@RentalStartDate", Booking.RentalStartDate);
                command.Parameters.AddWithValue("@RentalEndDate", Booking.RentalEndDate);
                command.Parameters.AddWithValue("@PickupLocation", Booking.PickupLocation);
                command.Parameters.AddWithValue("@DropoffLocation", Booking.DropoffLocation);
                command.Parameters.AddWithValue("@InitialRentalDays", Booking.InitialRentalDays);
                command.Parameters.AddWithValue("@RentalPricePerDay", Booking.RentalPricePerDay);
                command.Parameters.AddWithValue("@InitialTotalDueAmount", Booking.InitialTotalDueAmount);

                if (!string.IsNullOrEmpty(Booking.InitialCheckNotes))
                    command.Parameters.AddWithValue("@InitialCheckNotes", Booking.InitialCheckNotes);
                else
                    command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);


                var outputIdParam = new SqlParameter("@BookingID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                if (outputIdParam.Value != DBNull.Value)
                {
                    outputId = Convert.ToInt32(outputIdParam.Value);
                }



                return outputId;
            }
           
            }

            public static bool UpdateBookingID(clsBookingDTO Booking)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_UpdateBooking", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@BookingID", Booking.BookingId);
                command.Parameters.AddWithValue("@CustomerID", Booking.CustomerId);
                command.Parameters.AddWithValue("@VehicleID", Booking.VehicleId);
                command.Parameters.AddWithValue("@RentalStartDate", Booking.RentalStartDate);
                command.Parameters.AddWithValue("@RentalEndDate", Booking.RentalEndDate);
                command.Parameters.AddWithValue("@PickupLocation", Booking.PickupLocation);
                command.Parameters.AddWithValue("@DropoffLocation", Booking.DropoffLocation);
                command.Parameters.AddWithValue("@InitialRentalDays", Booking.InitialRentalDays);
                command.Parameters.AddWithValue("@RentalPricePerDay", Booking.RentalPricePerDay);
                command.Parameters.AddWithValue("@InitialTotalDueAmount", Booking.InitialTotalDueAmount);
                if (!string.IsNullOrEmpty(Booking.InitialCheckNotes))
                    command.Parameters.AddWithValue("@InitialCheckNotes", Booking.InitialCheckNotes);
                else
                    command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);


                connection.Open();
                    command.ExecuteNonQuery();
                    return true;

                }
            }

            public static bool DeleteBooking(int BookingID)
            {
         

                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_DeleteBookingbyiD", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookingID", BookingID);

                    connection.Open();

                    int rowsAffected = (int)command.ExecuteNonQuery();
                    return (rowsAffected == 1);


                }
            }
     

        public static DataTable GetAllBooking()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from Booking";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }
    }











