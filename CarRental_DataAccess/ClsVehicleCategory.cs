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
    public class ClsVehicleCategory
    {


     


        public static clsVehicleCategoryDTO? GetVehicleCategoriesByCategoryName(string CategoryName)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetVehicleCategoriesByCategoryName", connection))
            {


                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryName", CategoryName);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsVehicleCategoryDTO
                        (
                              reader.GetInt32(reader.GetOrdinal("CategoryID")),
                                    reader.GetString(reader.GetOrdinal("CategoryName"))

                        );
                    }


                    else
                    {
                        return null;
                    }
                }
            }
        }

              public static clsVehicleCategoryDTO? GetVehicleCategoriesByID(int ID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetVehicleCategoriesByID", connection))
            {


                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryID", ID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsVehicleCategoryDTO
                        (
                              reader.GetInt32(reader.GetOrdinal("CategoryID")),
                                    reader.GetString(reader.GetOrdinal("CategoryName"))

                        );
                    }


                    else
                    {
                        return null;
                    }
                }
            }


        }

        public static DataTable GetAllVehicleCategories()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from VehicleCategories order by CategoryName";

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
