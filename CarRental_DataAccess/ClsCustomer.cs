using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarRental_DataAccess.File;
using Microsoft.Data.SqlClient;

using System.Collections.Generic;
using System.Data;


namespace CarRental_DataAccess
{
    public class ClsCustomer
    {
        //static string _connectionString = @"Server=.;Database=CarRental;User Id=va;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        //static string _connectionString = @"Server=localhost\SQLEXPRESS;Database=CarRental;User Id=fa;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";
        //public static string _connectionString = "Server=.;Database=CarRental;User Id=sa;Password=123456;";
        //static string _connectionString = "Server=.;Database=CarRental;User Id=ba;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        //static string _connectionString = "Server=.;Database=CarRental;User Id=va;Password=123456;TrustServerCertificate=True;Connection Timeout=30;";

        public static List<clsCustomerDTO> GetCustomers()
        {
            var CustomersList = new List<clsCustomerDTO>();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllCustomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomersList.Add(new clsCustomerDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                    reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    reader.GetString(reader.GetOrdinal("SecondName")),
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    reader.GetString(reader.GetOrdinal("Phone")),
                                    reader.GetString(reader.GetOrdinal("DriverLicenseNumber"))
                                ));
                        }
                    }
                }


                return CustomersList;
            }

        }


      



        public static clsCustomerDTO GetCustomerById(int customerId)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetCustomer_ViewByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsCustomerDTO  
                        (

                            reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            reader.GetInt32(reader.GetOrdinal("PersonID")),
                            reader.GetString(reader.GetOrdinal("FirstName")),
                            reader.GetString(reader.GetOrdinal("SecondName")),
                            reader.GetString(reader.GetOrdinal("LastName")),
                            reader.GetString(reader.GetOrdinal("Phone")),
                            reader.GetString(reader.GetOrdinal("DriverLicenseNumber"))
                        );
                    }
                  
                    else
                    {
                        return null;
                    }
                }
            }
        }


        public static clsCustomerDTO? GetCustomerByPersonID(int ID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetCustomerByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", ID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsCustomerDTO
                        (

                            reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            reader.GetInt32(reader.GetOrdinal("PersonID")),
                            reader.GetString(reader.GetOrdinal("FirstName")),
                            reader.GetString(reader.GetOrdinal("SecondName")),
                            reader.GetString(reader.GetOrdinal("LastName")),
                            reader.GetString(reader.GetOrdinal("Phone")),
                            reader.GetString(reader.GetOrdinal("DriverLicenseNumber"))
                        );
                    }

                    else
                    {
                        return null;
                    }
                }
            }
        }






        public static int AddCustomer(clsCustomerDTO Customer)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_AddCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
              

                command.Parameters.AddWithValue("@PersonID", Customer.PersonId);
                command.Parameters.AddWithValue("@DriverLicenseNumber", Customer.DriverLicenseNumber);
              
                var outputIdParam = new SqlParameter("@CustomerID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                return (int)outputIdParam.Value;
            }
        }

        public static bool UpdatCustomer(clsCustomerDTO Customer)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_UpdateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;




                command.Parameters.AddWithValue("@CustomerID", Customer.CustomerId);
                command.Parameters.AddWithValue("@PersonID", Customer.PersonId);
                command.Parameters.AddWithValue("@DriverLicenseNumber", Customer.DriverLicenseNumber);
               
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

        public static bool DeleteCustomer(int BookingID)
        {


            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_DeleteCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", BookingID);
               
                connection.Open();

                int rowsAffected = (int)command.ExecuteNonQuery();
                return (rowsAffected == 1);


            }
        }
        public static DataTable GetAllCustomers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from CustomerView";

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





    

