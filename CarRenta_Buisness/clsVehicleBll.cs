using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental_DataAccess;
using System.Data;
using CarRental_DataAccess.File;
using CarRenta_Buisness1;

namespace CarRenta_Buisness
{
    public class clsVehicleBll
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public clsVehicleDTO VehicleDTO
        {
            get { return (new clsVehicleDTO(this.VehicleId, this.Make, this.Model, this.Year, this.Mileage, this.FuelTypeId, this.PlateNumber, this.CarCategoryId, this.RentalPricePerDay, this.IsAvailableForRent)); }
        }

        public int VehicleId { get; set; }

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public int Mileage { get; set; }

        public int FuelTypeId { get; set; }

        public string PlateNumber { get; set; } = null!;

        public int CarCategoryId { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public bool IsAvailableForRent { get; set; }
        public clsFuelTypeBll? FuelTypeInfo { get; set; }
        public clsVehicleCategoryBll? CarCategoryInfo { get; set; }
        public clsVehicleBll()
        {
            this.VehicleId = -1;
            this.Make ="";
            this.Model ="";
            this.Year = -1;
            this.Mileage = -1;
            this.FuelTypeId = -1;
            this.PlateNumber = "";
            this.CarCategoryId = -1;
            this.RentalPricePerDay = -1;
            this.IsAvailableForRent = true;
            Mode = enMode.AddNew;
        }
        public clsVehicleBll(clsVehicleDTO VehicleDTO, enMode cMode = enMode.AddNew)
        {
            this.VehicleId = VehicleDTO.VehicleId;
            this.Make = VehicleDTO.Make;
            this.Model = VehicleDTO.Model;
            this.Year = VehicleDTO.Year;
            this.Mileage = VehicleDTO.Mileage;
            this.FuelTypeId = VehicleDTO.FuelTypeId;
            this.PlateNumber = VehicleDTO.PlateNumber;
            this.CarCategoryId = VehicleDTO.CarCategoryId;
            this.RentalPricePerDay = VehicleDTO.RentalPricePerDay;
            this.IsAvailableForRent = VehicleDTO.IsAvailableForRent;
            this.FuelTypeInfo = clsFuelTypeBll.FindByID(VehicleDTO.FuelTypeId);
            this.CarCategoryInfo = clsVehicleCategoryBll.FindByID(VehicleDTO.CarCategoryId);
            Mode = cMode;
        }
        private bool _AddVehicle()
        {
            //call DataAccess Layer 

            this.VehicleId = ClsVehicle.AddVehicle(VehicleDTO);



            return (this.VehicleId != -1);
        }

        private bool _UpdateVehicle()
        {
            return ClsVehicle.UpdateVehicle(VehicleDTO);
        }

        public static clsVehicleBll Find(int ID)
        {

            clsVehicleDTO vehicleDto = ClsVehicle.GetVehicleById(ID);

            if (vehicleDto != null)
            //we return new object of that student with the right data
            {

                return new clsVehicleBll(vehicleDto, enMode.Update);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddVehicle())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateVehicle();

            }

            return false;
        }

        public static DataTable GetAllVehicle()
        {
            return ClsVehicle.GetAllVehicle();
        }

        public static bool IsVehicleExist(int ID)
        {
            return (ClsVehicle.GetVehicleById(ID) != null);
        }
        public static bool DeleteVehicle(int ID)
        {

            return ClsVehicle.DeleteVehicle(ID);
        }


    }
}

