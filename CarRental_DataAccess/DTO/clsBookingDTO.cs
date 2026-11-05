using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.DTO  
{
    public class clsBookingDTO
    {
      
        public clsBookingDTO(int bookingId, int customerId, int vehicleId, DateTime rentalStartDate, DateTime rentalEndDate, string pickupLocation, string dropoffLocation, byte initialRentalDays, decimal rentalPricePerDay, decimal initialTotalDueAmount, string? initialCheckNotes)

        {
this.BookingId = bookingId;
            this.CustomerId = customerId;
            this.VehicleId = vehicleId;
            this.RentalStartDate = rentalStartDate;
            this.RentalEndDate = rentalEndDate;
            this.PickupLocation = pickupLocation;
            this.DropoffLocation = dropoffLocation;
            this.InitialRentalDays = initialRentalDays;
            this.RentalPricePerDay = rentalPricePerDay;
            this.InitialTotalDueAmount = initialTotalDueAmount;
            this.InitialCheckNotes = initialCheckNotes;
        }

        public int BookingId { get; set; }

        public int CustomerId { get; set; }

        public int VehicleId { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public string PickupLocation { get; set; } = null!;

        public string DropoffLocation { get; set; } = null!;

        public byte InitialRentalDays { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public decimal InitialTotalDueAmount { get; set; }

        public string? InitialCheckNotes { get; set; }

        //public virtual Customer Customer { get; set; } = null!;

        //public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

        //public virtual Vehicle Vehicle { get; set; } = null!;

        //public virtual VehicleReturn? VehicleReturn { get; set; }
    }






}
