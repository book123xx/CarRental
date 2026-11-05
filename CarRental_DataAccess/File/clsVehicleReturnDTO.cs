using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.File
{
   

    public class clsVehicleReturnDTO
    {
        public clsVehicleReturnDTO(int returenId, DateTime actualReturnDate, byte actualRentalDays, int mileage, int consumedMileage, string finalCheckNotes, decimal additionalCharges, decimal actualTotalDueAmount, int bookingId)
        {
            this.ReturenId = returenId;
            this.ActualReturnDate = actualReturnDate;
            this.ActualRentalDays = actualRentalDays;
            this.Mileage = mileage;
            this.ConsumedMileage = consumedMileage;
            this.FinalCheckNotes = finalCheckNotes;
            this.AdditionalCharges = additionalCharges;
            this.ActualTotalDueAmount = actualTotalDueAmount;
            this.BookingId = bookingId;
        }




        public int ReturenId { get; set; }

        public DateTime ActualReturnDate { get; set; }

        public byte ActualRentalDays { get; set; }

        public int Mileage { get; set; }

        public int ConsumedMileage { get; set; }

        public string FinalCheckNotes { get; set; } = null!;

        public decimal AdditionalCharges { get; set; }

        public decimal ActualTotalDueAmount { get; set; }

        public int BookingId { get; set; }

    //    public virtual Booking Booking { get; set; } = null!;

    //    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();
    //}

}
}
