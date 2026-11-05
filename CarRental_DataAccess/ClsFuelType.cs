using CarRental_DataAccess.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsFuelType
    {



        public static clsFuleTypeDTO? GetFuelTypeById(int ID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetFuelTypesByID", connection))
            {


                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FuelTypeID", ID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsFuleTypeDTO
                        (
                              reader.GetInt32(reader.GetOrdinal("FuelTypeID")),
                                    reader.GetString(reader.GetOrdinal("FuelType"))

                        );
                    }


                    else
                    {
                        return null;
                    }
                }
            }
        }


        public static clsFuleTypeDTO? GetFuelTypeByType(string Type)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetFuelTypesByFuelType", connection))
            {
      
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FuelType", Type);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsFuleTypeDTO
                        (
                              reader.GetInt32(reader.GetOrdinal("FuelTypeID")),
                                    reader.GetString(reader.GetOrdinal("FuelType"))
                        );
                    }


                    else
                    {
                        return null;
                    }
                }
            }


        }

        public static DataTable GetAllFuelTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from FuelTypes order by FuelType";

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
