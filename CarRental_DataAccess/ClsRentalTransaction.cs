using CarRental_DataAccess.File;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace CarRental_DataAccess
{
    public class ClsRentalTransaction
    {

     
            public static List<clsRentalTransactionDTO> GeRentalTransaction()
            {
                var RentalTransactionList = new List<clsRentalTransactionDTO>();

                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllRentalTransaction", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                               int? ReturnID = reader["ReturnID"] != DBNull.Value
                                                            ? reader.GetInt32(reader.GetOrdinal("ReturnID"))
                                                            : null;

                            string? PaymentDetails = reader["PaymentDetails"] != DBNull.Value
                             ? reader.GetString(reader.GetOrdinal("PaymentDetails"))
                             : "";




                            decimal? PaidInitialTotalDueAmount = reader["PaidInitialTotalDueAmount"] != DBNull.Value
                                                         ? reader.GetDecimal(reader.GetOrdinal("PaidInitialTotalDueAmount"))
                                                         : null;

                            decimal? ActualTotalDueAmount = reader["ActualTotalDueAmount"] != DBNull.Value
                             ? reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount"))
                             : null;

                            decimal? TotalRemaining = reader["TotalRemaining"] != DBNull.Value
                                                         ? reader.GetDecimal(reader.GetOrdinal("TotalRemaining"))
                                                         : null;

                            decimal? TotalRefundedAmount = reader["TotalRefundedAmount"] != DBNull.Value
                                                         ? reader.GetDecimal(reader.GetOrdinal("TotalRefundedAmount"))
                                                         : null;

                            DateTime? UpdatedTransactionDate = reader["UpdatedTransactionDate"] != DBNull.Value
                             ? reader.GetDateTime(reader.GetOrdinal("UpdatedTransactionDate"))
                             : null;

                            RentalTransactionList.Add(new clsRentalTransactionDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("TransactionID")),
                                        reader.GetInt32(reader.GetOrdinal("BookingID")),
                                       ReturnID,
                                     PaymentDetails,
                                      reader.GetDecimal(reader.GetOrdinal("PaidInitialTotalDueAmount")),
                                       ActualTotalDueAmount,
                                       TotalRemaining,
                                      TotalRefundedAmount,
                                    reader.GetDateTime(reader.GetOrdinal("TransactionDate")),
                                   UpdatedTransactionDate

                                    ));
                            }
                        }
                    }


                    return RentalTransactionList;
                }

            }




            public static clsRentalTransactionDTO? GetRentalTransactionById(int rentalTransactionId)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_GetTransactionByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionID", rentalTransactionId);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                        int? ReturnID = reader["ReturnID"] != DBNull.Value
                              ? reader.GetInt32(reader.GetOrdinal("ReturnID"))
                              : null;

                        string? PaymentDetails = reader["PaymentDetails"] != DBNull.Value
                            ? reader.GetString(reader.GetOrdinal("PaymentDetails"))
                            : "";


                      

                        decimal? ActualTotalDueAmount = reader["ActualTotalDueAmount"] != DBNull.Value
                         ? reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount"))
                         : null;

                        decimal? TotalRemaining = reader["TotalRemaining"] != DBNull.Value
                                                     ? reader.GetDecimal(reader.GetOrdinal("TotalRemaining"))
                                                     : null;

                        decimal? TotalRefundedAmount = reader["TotalRefundedAmount"] != DBNull.Value
                                                     ? reader.GetDecimal(reader.GetOrdinal("TotalRefundedAmount"))
                                                     : null;

                        DateTime? UpdatedTransactionDate = reader["UpdatedTransactionDate"] != DBNull.Value
                         ? reader.GetDateTime(reader.GetOrdinal("UpdatedTransactionDate"))
                         : null;







                        return new clsRentalTransactionDTO
                            (
                                  reader.GetInt32(reader.GetOrdinal("TransactionID")),
                                        reader.GetInt32(reader.GetOrdinal("BookingID")),
                                       ReturnID,
                                       PaymentDetails,
                                     reader.GetDecimal(reader.GetOrdinal("PaidInitialTotalDueAmount")),
                                       ActualTotalDueAmount,
                                      TotalRemaining,
                                       TotalRefundedAmount,
                                    reader.GetDateTime(reader.GetOrdinal("TransactionDate")),
                                   UpdatedTransactionDate
                            );
                        }

                        else
                        {
                            return null;
                        }
                    }
                }
            }

        


            public static clsRentalTransactionDTO? GetTransactionByBookingID(int ID)
        {
            using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
            using (var command = new SqlCommand("SP_GetTransactionByBookingID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", ID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        int? ReturnID = reader["ReturnID"] != DBNull.Value
                              ? reader.GetInt32(reader.GetOrdinal("ReturnID"))
                              : null;

                        string? PaymentDetails = reader["PaymentDetails"] != DBNull.Value
                            ? reader.GetString(reader.GetOrdinal("PaymentDetails"))
                            : "";




                        decimal? ActualTotalDueAmount = reader["ActualTotalDueAmount"] != DBNull.Value
                         ? reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount"))
                         : null;

                        decimal? TotalRemaining = reader["TotalRemaining"] != DBNull.Value
                                                     ? reader.GetDecimal(reader.GetOrdinal("TotalRemaining"))
                                                     : null;

                        decimal? TotalRefundedAmount = reader["TotalRefundedAmount"] != DBNull.Value
                                                     ? reader.GetDecimal(reader.GetOrdinal("TotalRefundedAmount"))
                                                     : null;

                        DateTime? UpdatedTransactionDate = reader["UpdatedTransactionDate"] != DBNull.Value
                         ? reader.GetDateTime(reader.GetOrdinal("UpdatedTransactionDate"))
                         : null;







                        return new clsRentalTransactionDTO
                            (
                                  reader.GetInt32(reader.GetOrdinal("TransactionID")),
                                        reader.GetInt32(reader.GetOrdinal("BookingID")),
                                       ReturnID,
                                       PaymentDetails,
                                     reader.GetDecimal(reader.GetOrdinal("PaidInitialTotalDueAmount")),
                                       ActualTotalDueAmount,
                                      TotalRemaining,
                                       TotalRefundedAmount,
                                    reader.GetDateTime(reader.GetOrdinal("TransactionDate")),
                                   UpdatedTransactionDate
                            );
                    }

                    else
                    {
                        return null;
                    }
                }
            }
        }



        public static int AddRentalTransaction(clsRentalTransactionDTO rentalTransaction)
            {
            int outputId = -1;
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_AddNewRentalTransaction", connection))
                {



                command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookingID", rentalTransaction.BookingId);
                if (rentalTransaction.ReturnId.HasValue)
                    command.Parameters.AddWithValue("@ReturnID", rentalTransaction.ReturnId.HasValue);
                else
                    command.Parameters.AddWithValue("@ReturnID", DBNull.Value);

              

                if (!string.IsNullOrEmpty(rentalTransaction.PaymentDetails))
                    command.Parameters.AddWithValue("@PaymentDetails", rentalTransaction.PaymentDetails);
                else
                    command.Parameters.AddWithValue("@PaymentDetails", DBNull.Value);



                    command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", rentalTransaction.PaidInitialTotalDueAmount);
               

            
                if( rentalTransaction.ActualTotalDueAmount.HasValue)
                    command.Parameters.AddWithValue("@ActualTotalDueAmount", rentalTransaction.ActualTotalDueAmount);
                else
                    command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);



                if (rentalTransaction.TotalRemaining.HasValue)
                    command.Parameters.AddWithValue("@TotalRemaining", rentalTransaction.TotalRemaining);
                else
                    command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);



                if (rentalTransaction.TotalRefundedAmount.HasValue)
                    command.Parameters.AddWithValue("@TotalRefundedAmount", rentalTransaction.TotalRefundedAmount);
                else
                    command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);



                
                    command.Parameters.AddWithValue("@TransactionDate", rentalTransaction.TransactionDate);

                if (rentalTransaction.UpdatedTransactionDate.HasValue)
                    command.Parameters.AddWithValue("@UpdatedTransactionDate", rentalTransaction.UpdatedTransactionDate);
                else
                    command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);


                    var outputIdParam = new SqlParameter("@TransactionID", SqlDbType.Int)
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

        public static bool UpdateRentalTransaction(clsRentalTransactionDTO rentalTransaction)
            {
                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_UpdateRentalTransaction", connection))
                {

              

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TransactionID", rentalTransaction.TransactionId);
                command.Parameters.AddWithValue("@BookingID", rentalTransaction.BookingId);
                if (rentalTransaction.ReturnId.HasValue)
                    command.Parameters.AddWithValue("@ReturnID", rentalTransaction.ReturnId);
                else
                    command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
              
                if (!string.IsNullOrEmpty(rentalTransaction.PaymentDetails))
                    command.Parameters.AddWithValue("@PaymentDetails", rentalTransaction.PaymentDetails);
                else
                    command.Parameters.AddWithValue("@PaymentDetails", DBNull.Value);

                    command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", rentalTransaction.PaidInitialTotalDueAmount);
               


                if (rentalTransaction.ActualTotalDueAmount.HasValue)
                    command.Parameters.AddWithValue("@ActualTotalDueAmount", rentalTransaction.ActualTotalDueAmount);
                else
                    command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);




                if (rentalTransaction.TotalRemaining.HasValue)
                    command.Parameters.AddWithValue("@TotalRemaining", rentalTransaction.TotalRemaining);
                else
                    command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);



                if (rentalTransaction.TotalRefundedAmount.HasValue)
                    command.Parameters.AddWithValue("@TotalRefundedAmount", rentalTransaction.TotalRefundedAmount);
                else
                    command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);


                command.Parameters.AddWithValue("@TransactionDate", rentalTransaction.TransactionDate);



                if (rentalTransaction.UpdatedTransactionDate.HasValue)
                    command.Parameters.AddWithValue("@UpdatedTransactionDate", rentalTransaction.UpdatedTransactionDate);
                else
                    command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);

           
                connection.Open();
                    command.ExecuteNonQuery();
                    return true;

                }
            }

            public static bool DeleteRentalTransaction(int personID)
            {


                using (var connection = new SqlConnection(clsDataAccessSettings._connectionString))
                using (var command = new SqlCommand("SP_DeleteRentalTransaction", connection))
                {
             
                command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionID", personID);

                    connection.Open();

                    int rowsAffected = (int)command.ExecuteNonQuery();
                    return (rowsAffected == 1);


                }
            }
        public static DataTable GetAllRentalTransaction()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings._connectionString);

            string query = "select * from RentalTransaction";

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







