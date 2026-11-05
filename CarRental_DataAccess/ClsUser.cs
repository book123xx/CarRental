using CarRental_DataAccess.File;
using Microsoft.Data.SqlClient;
using System.Data;

using System;
using System.Collections.Generic;


namespace CarRental_DataAccess
{
    public class ClsUser
    {
        public static List<clsUserDTO> GetUsers()
        {
            var UserList = new List<clsUserDTO>();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllUsers_View", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserList.Add(new clsUserDTO
                            (
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetInt32(reader.GetOrdinal("PersonID")),
                                reader.GetString(reader.GetOrdinal("UserName")),
                                (byte[])reader["Password"],
                                (byte[])reader["Salt"],
                                reader.GetInt32(reader.GetOrdinal("Iterations")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive"))
                            ));
                        }
                    }
                }
                return UserList;
            }
        }

        public static clsUserDTO? GetUserById(int user)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetUserViewByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", user);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsUserDTO
                        (
                            reader.GetInt32(reader.GetOrdinal("UserID")),
                            reader.GetInt32(reader.GetOrdinal("PersonID")),
                            reader.GetString(reader.GetOrdinal("UserName")),
                             
                            (byte[])reader["Password"],
                            (byte[])reader["Salt"],
                            reader.GetInt32(reader.GetOrdinal("Iterations")),
                            reader.GetBoolean(reader.GetOrdinal("IsActive"))
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static clsUserDTO? GetUserInfoByUsername(string username)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_Get_UserByUserName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", username);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        return new clsUserDTO
                        (
                            reader.GetInt32(reader.GetOrdinal("UserID")),
                            reader.GetInt32(reader.GetOrdinal("PersonID")),
                            reader.GetString(reader.GetOrdinal("UserName")),
                          
                            (byte[])reader["Password"], 
(byte[])reader["Salt"],   
                            reader.GetInt32(reader.GetOrdinal("Iterations")),
                            reader.GetBoolean(reader.GetOrdinal("IsActive"))
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static clsUserDTO? GetUserInfoByPersonID(int personID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetUserViewByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsUserDTO
                        (
                            reader.GetInt32(reader.GetOrdinal("UserID")),
                            reader.GetInt32(reader.GetOrdinal("PersonID")),
                            reader.GetString(reader.GetOrdinal("UserName")),
                            (byte[])reader["Password"],
                            (byte[])reader["Salt"],
                            reader.GetInt32(reader.GetOrdinal("Iterations")),
                            reader.GetBoolean(reader.GetOrdinal("IsActive"))
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static int AddNewUser(clsUserDTO user)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_AddUser_2", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", user.PersonId);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.PasswordHash);
                command.Parameters.AddWithValue("@Salt", user.PasswordSalt);
                command.Parameters.AddWithValue("@Iterations", user.Iterations);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                var outputIdParam = new SqlParameter("@UserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteScalar();

                return (int)outputIdParam.Value;
            }
        }

        public static bool UpdateUser(clsUserDTO user)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", user.UserId);
                command.Parameters.AddWithValue("@PersonID", user.PersonId);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.PasswordHash);
                command.Parameters.AddWithValue("@Salt", user.PasswordSalt);
                command.Parameters.AddWithValue("@Iterations", user.Iterations);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }

        public static bool isUserExist(string username)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_CheckUserNameExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", username);

                var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                connection.Open();
                command.ExecuteNonQuery();

                int result = (int)returnParameter.Value;
                return (result == 1);
            }
        }

        public static bool CheckPersonExists(int PersonID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_CheckPersonExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);

                var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                connection.Open();
                command.ExecuteNonQuery();

                int result = (int)returnParameter.Value;
                return (result == 1);
            }
        }

        public static bool DeleteUser(int userID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_DeleteUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return (rowsAffected > 0);
            }
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString))
            {
                string query = "select * from ViewUsers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                       
                    }
                }
            }
            return dt;
        }
    }
}