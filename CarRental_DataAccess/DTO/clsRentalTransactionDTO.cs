using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.DTO
{
    

    public  class clsRentalTransactionDTO
    {
       
        public clsRentalTransactionDTO(int transactionId, int bookingId, int? returnId, string? paymentDetails, decimal paidInitialTotalDueAmount, decimal? actualTotalDueAmount, decimal? totalRemaining, decimal? totalRefundedAmount, DateTime transactionDate, DateTime? updatedTransactionDate)
        {
            this.TransactionId = transactionId;
            this.BookingId = bookingId;
            this.ReturnId = returnId;
            this.PaymentDetails = paymentDetails;
            this.PaidInitialTotalDueAmount = paidInitialTotalDueAmount;
            this.ActualTotalDueAmount = actualTotalDueAmount;
            this.TotalRemaining = totalRemaining;
            this.TotalRefundedAmount = totalRefundedAmount;
            this.TransactionDate = transactionDate;
            this.UpdatedTransactionDate = updatedTransactionDate;
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

        //public virtual Booking Booking { get; set; } = null!;

        //public virtual VehicleReturn? Return { get; set; }
    }

}

