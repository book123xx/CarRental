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
using System.Linq.Expressions;
using Microsoft.IdentityModel.Tokens.Experimental;

namespace CarRental_DataAccess
{
    public class ClsPeople
    {   
        
        public static List<clsPeopleDTO> GetPeople()
            {
                var PeopleList = new List<clsPeopleDTO>();

                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllPeople", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            string? ImagePath = reader["ImagePath"] != DBNull.Value
                          ? reader.GetString(reader.GetOrdinal("ImagePath"))
                          : "";

                            PeopleList.Add(new clsPeopleDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("PersonID")),
                                        reader.GetString(reader.GetOrdinal("FirstName")),
                                        reader.GetString(reader.GetOrdinal("SecondName")),
                                        reader.GetString(reader.GetOrdinal("LastName")),
                                        reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                        reader.GetByte(reader.GetOrdinal("Gender")),
                                        reader.GetString(reader.GetOrdinal("Phone")),
                                        reader.GetString(reader.GetOrdinal("Email")),
                                        ImagePath
                                    ));
                            }
                        }
                    }


                    return PeopleList;
                }

            }




            public static clsPeopleDTO GetPersonById(int personId)
            {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetPersonByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personId);
               
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string? ImagePath = reader["ImagePath"] != DBNull.Value
                              ? reader.GetString(reader.GetOrdinal("ImagePath"))
                              : "";

                            return new clsPeopleDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    reader.GetString(reader.GetOrdinal("SecondName")),
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    reader.GetByte(reader.GetOrdinal("Gender")),
                                    reader.GetString(reader.GetOrdinal("Phone")),
                                    reader.GetString(reader.GetOrdinal("Email")),
                                   ImagePath
                                );
                        }

                        else
                        {
                            return null;
                        }
                    }
               

                   
                    
                    
                }
            }
        






            public static int AddPerson(clsPeopleDTO Person)
            {
            int outputId = -1;
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_AddPerson", connection))
                {

          

                   

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", Person.FirstName);
                command.Parameters.AddWithValue("@SecondName", Person.SecondName);
                command.Parameters.AddWithValue("@LastName", Person.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Person.Gender);
                command.Parameters.AddWithValue("@Phone", Person.Phone);
                command.Parameters.AddWithValue("@Email", Person.Email);

                if (!string.IsNullOrEmpty(Person.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", Person.ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);



               
                var outputIdParam = new SqlParameter("@PersonID", SqlDbType.Int)
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

            public static bool UpdatePerson(clsPeopleDTO Person)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_UpdatePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@PersonID", Person.PersonId);
                command.Parameters.AddWithValue("@FirstName", Person.FirstName);
                command.Parameters.AddWithValue("@SecondName", Person.SecondName);
                command.Parameters.AddWithValue("@LastName", Person.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Person.Gender);
                command.Parameters.AddWithValue("@Phone", Person.Phone);
                command.Parameters.AddWithValue("@Email", Person.Email);

                if (!string.IsNullOrEmpty(Person.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", Person.ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                connection.Open();
                    command.ExecuteNonQuery();
                    return true;

                }
            }

        public static bool DeletePerson(int personID)
        {


            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_DeletePersonbyID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);
                   connection.Open();

                    var rowsAffected = (int)command.ExecuteNonQuery();

                    return (rowsAffected == 1);
              

                
            }
           
        }
        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = @"

SELECT        PersonID, FirstName + ' ' + SecondName + ' ' + LastName AS FullName, DateOfBirth,CASE  
        WHEN Gender = 0 THEN 'Male'  
        ELSE 'Female'  
    END AS Gender  
, Phone, Email, ImagePath    
FROM            dbo.People";
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








