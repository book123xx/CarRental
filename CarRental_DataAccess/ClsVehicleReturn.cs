using CarRental_DataAccess.File;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;

using System.Linq;



using System.Transactions;



namespace CarRental_DataAccess
{
    public class ClsVehicleReturn
    {




            public static List<clsVehicleReturnDTO> GetAllVehicles()
            {
                var VehicleList = new List<clsVehicleReturnDTO>();
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllVehicleReturns", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                VehicleList.Add(new clsVehicleReturnDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ReturenID")),
                                        reader.GetDateTime(reader.GetOrdinal("ActualReturnDate")),
                                        reader.GetByte(reader.GetOrdinal("ActualRentalDays")),
                                        reader.GetInt32(reader.GetOrdinal("Mileage")),
                                        reader.GetInt32(reader.GetOrdinal("ConsumedMileage")),
                                        reader.GetString(reader.GetOrdinal("FinalCheckNotes")),
                                        reader.GetDecimal(reader.GetOrdinal("AdditionalCharges")),
                                         reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount")),
                                        reader.GetInt32(reader.GetOrdinal("BookingID"))


                                    ));
                            }
                        }
                    }
                }
                return VehicleList;
            }






            public static clsVehicleReturnDTO? GetVehicleReturnsBybookingID(int BookingID)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_GetVehicleReturnsBybookingID", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookingID", BookingID);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new clsVehicleReturnDTO
                            (
                                 reader.GetInt32(reader.GetOrdinal("ReturenID")),
                                        reader.GetDateTime(reader.GetOrdinal("ActualReturnDate")),
                                        reader.GetByte(reader.GetOrdinal("ActualRentalDays")),
                                        reader.GetInt32(reader.GetOrdinal("Mileage")),
                                        reader.GetInt32(reader.GetOrdinal("ConsumedMileage")),
                                        reader.GetString(reader.GetOrdinal("FinalCheckNotes")),
                                        reader.GetDecimal(reader.GetOrdinal("AdditionalCharges")),
                                         reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount")),
                                        reader.GetInt32(reader.GetOrdinal("BookingID"))

                            );
                        }


                        else
                        {
                            return null;
                        }
                    }
                }
            }



        public static clsVehicleReturnDTO? GetVehicleReturnsByID(int ID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetVehicleReturnsByID", connection))
            {


                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReturenID", ID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsVehicleReturnDTO
                        (
                             reader.GetInt32(reader.GetOrdinal("ReturenID")),
                                    reader.GetDateTime(reader.GetOrdinal("ActualReturnDate")),
                                    reader.GetByte(reader.GetOrdinal("ActualRentalDays")),
                                    reader.GetInt32(reader.GetOrdinal("Mileage")),
                                    reader.GetInt32(reader.GetOrdinal("ConsumedMileage")),
                                    reader.GetString(reader.GetOrdinal("FinalCheckNotes")),
                                    reader.GetDecimal(reader.GetOrdinal("AdditionalCharges")),
                                     reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount")),
                                    reader.GetInt32(reader.GetOrdinal("BookingID"))

                        );
                    }


                    else
                    {
                        return null;
                    }
                }
            }
        }





        public static int AddNewVehicleReturn(clsVehicleReturnDTO VehicleReturn)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_AddNewVehicleReturn", connection))
                {




                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@ActualReturnDate", VehicleReturn.ActualReturnDate);
                    command.Parameters.AddWithValue("@ActualRentalDays", VehicleReturn.ActualRentalDays);
                    command.Parameters.AddWithValue("@Mileage", VehicleReturn.Mileage);
                    command.Parameters.AddWithValue("@ConsumedMileage", VehicleReturn.ConsumedMileage);
                    command.Parameters.AddWithValue("@FinalCheckNotes", VehicleReturn.FinalCheckNotes);
                    command.Parameters.AddWithValue("@AdditionalCharges", VehicleReturn.AdditionalCharges);
                    command.Parameters.AddWithValue("@ActualTotalDueAmount", VehicleReturn.ActualTotalDueAmount);
                    command.Parameters.AddWithValue("@BookingID", VehicleReturn.BookingId);





                    var outputIdParam = new SqlParameter("@ReturenID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return (int)outputIdParam.Value;
                }
            }

            public static bool UpdateVehicleReturn(clsVehicleReturnDTO vehicleReturn)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_UpdateVehicleReturn", connection))
                {



                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ReturenID", vehicleReturn.ReturenId);

                    command.Parameters.AddWithValue("@ActualReturnDate", vehicleReturn.ActualReturnDate);
                    command.Parameters.AddWithValue("@ActualRentalDays", vehicleReturn.ActualRentalDays);
                    command.Parameters.AddWithValue("@Mileage", vehicleReturn.Mileage);
                    command.Parameters.AddWithValue("@ConsumedMileage", vehicleReturn.ConsumedMileage);
                    command.Parameters.AddWithValue("@FinalCheckNotes", vehicleReturn.FinalCheckNotes);
                    command.Parameters.AddWithValue("@AdditionalCharges", vehicleReturn.AdditionalCharges);
                    command.Parameters.AddWithValue("@ActualTotalDueAmount", vehicleReturn.ActualTotalDueAmount);
                    command.Parameters.AddWithValue("@BookingID", vehicleReturn.BookingId);


                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;

                }
            }

            public static bool DeleteVehicleReturn(int ReturenID)
            {


                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_DeleteVehicleReturnbyID", connection))
                {




                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ReturenID", ReturenID);

                    connection.Open();


                    int rowsAffected = (int)command.ExecuteNonQuery();
                    return (rowsAffected == 1);


                }
            }
        public static DataTable GetAllVehicleReturns()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from VehicleReturns";

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


