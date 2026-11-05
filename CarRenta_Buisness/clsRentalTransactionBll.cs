using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental_DataAccess;
using System.Data;
using CarRental_DataAccess.DTO;
namespace CarRenta_Buisness
{
    public class clsRentalTransactionBll
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public clsRentalTransactionDTO RentalTransactionDTO
        {
            get { return (new clsRentalTransactionDTO(this.TransactionId, this.BookingId, this.ReturnId, this.PaymentDetails, this.PaidInitialTotalDueAmount, this.ActualTotalDueAmount, this.TotalRemaining, this.TotalRefundedAmount, this.TransactionDate, this.UpdatedTransactionDate)); }
        }

        public int TransactionId { get; set; }

        public int BookingId { get; set; }

        public int? ReturnId { get; set; }

        public string? PaymentDetails { get; set; }

        public decimal PaidInitialTotalDueAmount { get; set; }

        public decimal? ActualTotalDueAmount { get; set; }

        public decimal? TotalRemaining { get; set; }

        public decimal? TotalRefundedAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime? UpdatedTransactionDate { get; set; }

        public clsRentalTransactionBll()
        {
            this.TransactionId = -1;
            this.BookingId = -1;
            this.ReturnId = null;
            this.PaymentDetails = null;
            this.PaidInitialTotalDueAmount = -1;
            this.ActualTotalDueAmount = null;
            this.TotalRemaining = null;
            this.TotalRefundedAmount = null;
            this.TransactionDate = DateTime.Now;
            this.UpdatedTransactionDate = null;
            Mode = enMode.AddNew;
        }
        public clsRentalTransactionBll(clsRentalTransactionDTO RentalTransactionDTO, enMode cMode = enMode.AddNew)
        {
            this.TransactionId = RentalTransactionDTO.TransactionId;
            this.BookingId = RentalTransactionDTO.BookingId;
            this.ReturnId = RentalTransactionDTO.ReturnId;
            this.PaymentDetails = RentalTransactionDTO.PaymentDetails;
            this.PaidInitialTotalDueAmount = RentalTransactionDTO.PaidInitialTotalDueAmount;
            this.ActualTotalDueAmount = RentalTransactionDTO.ActualTotalDueAmount;
            this.TotalRemaining = RentalTransactionDTO.TotalRemaining;
            this.TotalRefundedAmount = RentalTransactionDTO.TotalRefundedAmount;
            this.TransactionDate = RentalTransactionDTO.TransactionDate;
            this.UpdatedTransactionDate = RentalTransactionDTO.UpdatedTransactionDate;
            Mode = cMode;
        }

        private bool _AddNewRentalTransaction()
        {
            //call DataAccess Layer 

            this.TransactionId = ClsRentalTransaction.AddRentalTransaction(RentalTransactionDTO);

            return (this.TransactionId != -1);
        }

        private bool _UpdateRentalTransaction()
        {
            return ClsRentalTransaction.UpdateRentalTransaction(RentalTransactionDTO);
        }
        public static clsRentalTransactionBll? Find(int ID)
        {

            clsRentalTransactionDTO? RentalTransactionDTO = ClsRentalTransaction.GetRentalTransactionById(ID);

            if (RentalTransactionDTO != null)
            //we return new object of that student with the right data
            {

                return new clsRentalTransactionBll(RentalTransactionDTO, enMode.Update);
            }
            else
                return null;
        }
        public static clsRentalTransactionBll? FindByBookingID(int ID)
        {

            clsRentalTransactionDTO? RentalTransactionDTO = ClsRentalTransaction.GetTransactionByBookingID(ID);

            if (RentalTransactionDTO != null)
            //we return new object of that student with the right data
            {

                return new clsRentalTransactionBll(RentalTransactionDTO, enMode.Update);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalTransaction())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRentalTransaction();

            }

            return false;
        }


        public static bool DeletePerson(int ID)
        {

            return ClsRentalTransaction.DeleteRentalTransaction(ID);
        }

        public static DataTable GetAllRentalTransaction()
        {
            return ClsRentalTransaction.GetAllRentalTransaction();
        }
    }
}

  
