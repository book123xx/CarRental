
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
    public class clsVehicleReturnBll
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public clsVehicleReturnDTO vehicleReturnDTO
        {
            get { return (new clsVehicleReturnDTO(this.ReturenId, this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMileage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount, this.BookingId)); }
        }


        public int ReturenId { get; set; }

        public DateTime ActualReturnDate { get; set; }

        public byte ActualRentalDays { get; set; }

        public int Mileage { get; set; }

        public int ConsumedMileage { get; set; }

        public string FinalCheckNotes { get; set; } = null!;

        public decimal AdditionalCharges { get; set; }

        public decimal ActualTotalDueAmount { get; set; }
        public clsBookingBll bookinginfo { get; set; }
        public int BookingId { get; set; }
        public clsVehicleReturnBll()
        {
            this.ReturenId = -1;
            this.ActualReturnDate = DateTime.Now;
            this.ActualRentalDays = 0;
            this.Mileage = 0;
            this.ConsumedMileage = 0;
            this.FinalCheckNotes = "";
            this.AdditionalCharges = 0;
            this.ActualTotalDueAmount = 0;
            this.BookingId = -1;
            this.bookinginfo = clsBookingBll.Find(this.BookingId);
            Mode = enMode.AddNew;
        }   

        public clsVehicleReturnBll(clsVehicleReturnDTO VehicleReturnDTO, enMode cMode = enMode.AddNew)
        {
            this.ReturenId = VehicleReturnDTO.ReturenId;
            this.ActualReturnDate = VehicleReturnDTO.ActualReturnDate;
            this.ActualRentalDays = VehicleReturnDTO.ActualRentalDays;
            this.Mileage = VehicleReturnDTO.Mileage;
            this.ConsumedMileage = VehicleReturnDTO.ConsumedMileage;
            this.FinalCheckNotes = VehicleReturnDTO.FinalCheckNotes;
            this.AdditionalCharges = VehicleReturnDTO.AdditionalCharges;
            this.ActualTotalDueAmount = VehicleReturnDTO.ActualTotalDueAmount;
            this.bookinginfo = clsBookingBll.Find(vehicleReturnDTO.BookingId);
            this.BookingId = VehicleReturnDTO.BookingId;
            Mode = cMode;
        }
        private bool _AddNewVehicleReturn()
        {
            //call DataAccess Layer 

            this.ReturenId = ClsVehicleReturn.AddNewVehicleReturn(vehicleReturnDTO);



            return (this.ReturenId != -1);
        }

        private bool _UpdateVehicleReturn()
        {
            return ClsVehicleReturn.UpdateVehicleReturn(vehicleReturnDTO);
        }
        public static clsVehicleReturnBll?  Find(int ID)
        {

            clsVehicleReturnDTO? VehicleReturnDTO = ClsVehicleReturn.GetVehicleReturnsByID(ID);

            if (VehicleReturnDTO != null)
            //we return new object of that student with the right data
            {

                return new clsVehicleReturnBll(VehicleReturnDTO, enMode.Update);
            }
            else
                return null;
        }
        public static clsVehicleReturnBll? FindbyBookingID(int ID)
        {

            clsVehicleReturnDTO? VehicleReturnDTO = ClsVehicleReturn.GetVehicleReturnsBybookingID(ID);

            if (VehicleReturnDTO != null)
         
            {

                return new clsVehicleReturnBll(VehicleReturnDTO, enMode.Update);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleReturn())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateVehicleReturn();

            }

            return false;
        }
        
        public static DataTable GetallVehicleReturns()
        { 

            return ClsVehicleReturn.GetAllVehicleReturns();
        }

        public static bool IsbookingExist(int ID)

        {
            return (ClsVehicleReturn.GetVehicleReturnsBybookingID(ID) != null);
        }
        public static bool DeleteVehicleReturn(int ID)
        {

            return ClsVehicleReturn.DeleteVehicleReturn(ID);
        }


    }

}