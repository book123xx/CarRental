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

using System.Threading.Tasks;


using System.Collections.Generic;


using System.Threading.Tasks;
using System.Transactions;



namespace CarRental_DataAccess
{
    public class ClsVehicle
    {


        //public static List<clsVehicleDTO> GetVehicles()
        //{
        //    var VehicleList = new List<clsVehicleDTO>();
        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SP_GetAllVehicle", conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            conn.Open();
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    VehicleList.Add(new clsVehicleDTO
        //                        (
        //                            reader.GetInt32(reader.GetOrdinal("VehicleID")),
        //                            reader.GetString(reader.GetOrdinal("Make")),
        //                            reader.GetString(reader.GetOrdinal("Model")),
        //                            reader.GetInt32(reader.GetOrdinal("VehicleYear")),
        //                            reader.GetInt32(reader.GetOrdinal("Mileage")),
        //                            reader.GetInt32(reader.GetOrdinal("FuelTypeID")),
        //                            reader.GetString(reader.GetOrdinal("PlateNumber")),
        //                             reader.GetInt32(reader.GetOrdinal("CarCategoryID")),
        //                            reader.GetDecimal(reader.GetOrdinal("RentalPricePerDay")),
        //                                           reader.GetBoolean(reader.GetOrdinal("IsAvailableForRent"))

        //                        ));
        //                }
        //            }
        //        }
        //    }
        //    return VehicleList;
        //}


        

 

            public static clsVehicleDTO GetVehicleById(int VehicleID)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_GetVehicleByID", connection))
            {
                



                command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VehicleID", VehicleID);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new clsVehicleDTO
                            (
                                 reader.GetInt32(reader.GetOrdinal("VehicleID")),
                                    reader.GetString(reader.GetOrdinal("Make")),
                                    reader.GetString(reader.GetOrdinal("Model")),
                                    reader.GetInt32(reader.GetOrdinal("VehicleYear")),
                                    reader.GetInt32(reader.GetOrdinal("Mileage")),
                                    reader.GetInt32(reader.GetOrdinal("FuelTypeID")),
                                    reader.GetString(reader.GetOrdinal("PlateNumber")),
                                     reader.GetInt32(reader.GetOrdinal("CarCategoryID")),
                                    reader.GetDecimal(reader.GetOrdinal("RentalPricePerDay")),
                                                   reader.GetBoolean(reader.GetOrdinal("IsAvailableForRent"))

                            );
                        }


                        else
                        {
                            return null;
                        }
                    }
                }
            }






            public static int AddVehicle(clsVehicleDTO Vehicle)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_AddVehicle", connection))
                {

            




                    command.CommandType = CommandType.StoredProcedure;




                    command.Parameters.AddWithValue("@Make", Vehicle.Make);
                    command.Parameters.AddWithValue("@Model", Vehicle.Model);
                    command.Parameters.AddWithValue("@VehicleYear", Vehicle.Year);
                    command.Parameters.AddWithValue("@Mileage", Vehicle.Mileage);
                    command.Parameters.AddWithValue("@FuelTypeID", Vehicle.FuelTypeId);
                    command.Parameters.AddWithValue("@PlateNumber", Vehicle.PlateNumber);
                command.Parameters.AddWithValue("@CarCategoryID", Vehicle.CarCategoryId);
                command.Parameters.AddWithValue("@RentalPricePerDay", Vehicle.RentalPricePerDay);
                command.Parameters.AddWithValue("@IsAvailableForRent", Vehicle.IsAvailableForRent);

             



                var outputIdParam = new SqlParameter("@VehicleID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return (int)outputIdParam.Value;
                }
            }

            public static bool UpdateVehicle(clsVehicleDTO vehicle)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_Update_Vehicle", connection))
                {

       




                    command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@VehicleID", vehicle.VehicleId);
                command.Parameters.AddWithValue("@Make", vehicle.Make);
                command.Parameters.AddWithValue("@Model", vehicle.Model);
                    command.Parameters.AddWithValue("@VehicleYear", vehicle.Year);
                    command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                    command.Parameters.AddWithValue("@FuelTypeID", vehicle.FuelTypeId);
                    command.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                    command.Parameters.AddWithValue("@CarCategoryID", vehicle.CarCategoryId);
                    command.Parameters.AddWithValue("@RentalPricePerDay", vehicle.RentalPricePerDay);
                    command.Parameters.AddWithValue("@IsAvailableForRent", vehicle.IsAvailableForRent);


                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;

                }
            }

            public static bool DeleteVehicle(int VehicleID)
            {


                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_DeleteVehicle", connection))
                {

           

                command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VehicleID", VehicleID);

                    connection.Open();


                    int rowsAffected = (int)command.ExecuteNonQuery();
                    return (rowsAffected == 1);


                }
            }
        public static DataTable GetAllVehicle()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from Vehicle ";

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
