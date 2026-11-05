using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental_DataAccess;
using System.Data;
using CarRental_DataAccess.File;
namespace CarRenta_Buisness
{
    public class clsBookingBll
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;



        public clsBookingDTO BookingDTO
        {
            get { return (new clsBookingDTO(this.BookingId, this.CustomerId, this.VehicleId, this.RentalStartDate, this.RentalEndDate, this.PickupLocation, this.DropoffLocation, this.InitialRentalDays, this.RentalPricePerDay, this.InitialTotalDueAmount, this.InitialCheckNotes)); }
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
        public clsCustomerBll CustomerInfo { get; set; }

        //public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

        public clsVehicleBll Vehicleinfo { get; set; }
        public clsRentalTransactionBll? RentalTransactionInfo { get; set; }

        public clsVehicleReturnBll? VehicleReturnInfo { get; set; }
        public clsBookingBll()
        {
            this.BookingId = -1;
            this.CustomerId = -1;
            this.VehicleId = -1;
            this.RentalStartDate = DateTime.Now;
            this.RentalEndDate = DateTime.Now;
            this.PickupLocation = "";
            this.DropoffLocation = "";
            this.InitialRentalDays = 0;
            this.RentalPricePerDay = -1;
            this.InitialTotalDueAmount = -1 ;
            this.InitialCheckNotes = "";
            this.CustomerInfo =clsCustomerBll.Find(this.CustomerId);
          
            this.VehicleReturnInfo=clsVehicleReturnBll.Find(this.BookingId);
            this.RentalTransactionInfo = clsRentalTransactionBll.FindByBookingID(this.BookingId);

            Mode = enMode.AddNew;
        }   
        public clsBookingBll(clsBookingDTO BookingDTO, enMode cMode = enMode.AddNew)
        {
            this.BookingId = BookingDTO.BookingId;
            this.CustomerId = BookingDTO.CustomerId;
            this.VehicleId = BookingDTO.VehicleId;
            this.RentalStartDate = BookingDTO.RentalStartDate;
            this.RentalEndDate = BookingDTO.RentalEndDate;
            this.PickupLocation = BookingDTO.PickupLocation;
            this.DropoffLocation = BookingDTO.DropoffLocation;
            this.InitialRentalDays = BookingDTO.InitialRentalDays;
            this.RentalPricePerDay = BookingDTO.RentalPricePerDay;
            this.InitialTotalDueAmount = BookingDTO.InitialTotalDueAmount;
            this.InitialCheckNotes = BookingDTO.InitialCheckNotes;
            this.CustomerInfo = clsCustomerBll.Find(BookingDTO.CustomerId);
            this.Vehicleinfo = clsVehicleBll.Find(BookingDTO.VehicleId);
            this.VehicleReturnInfo = clsVehicleReturnBll.Find(BookingDTO.BookingId);
            this.RentalTransactionInfo = clsRentalTransactionBll.Find(BookingDTO.BookingId);
            Mode = cMode;
        }
        private bool _AddNewbooking() { 
        
            //call DataAccess Layer 

            this.BookingId = Clsbooking.AddBooking(BookingDTO);

            return (this.BookingId != -1);
        }
      

        private bool _Updatebooking()
        {
            return Clsbooking.UpdateBookingID(BookingDTO);
        }

        public static List<clsBookingDTO> GetAllBookings()
        {
            return Clsbooking.GetAllBookings();
        }

        public static clsBookingBll Find(int ID)
        {

            clsBookingDTO bookingDTO = Clsbooking.GetBookingById(ID);

            if (bookingDTO != null)
            //we return new object of that student with the right data
            {

                return new clsBookingBll(bookingDTO, enMode.Update);
            }
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewbooking())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _Updatebooking();

            }

            return false;
        }
        public static DataTable GetAllBooking()
        {
            return Clsbooking.GetAllBooking();
        }
        public static bool isBookingExist(int ID)
        {
            return (Clsbooking.GetBookingById(ID)!=null);
        }
        public static bool DeleteBooking(int ID)
        {
            return Clsbooking.DeleteBooking(ID);
        }



    
    }
}
