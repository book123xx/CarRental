using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.DTO
{
    
    public class clsVehicleDTO
    {


        public clsVehicleDTO(int vehicleId, string make, string model, int year, int mileage, int fuelTypeId, string plateNumber, int carCategoryId, decimal rentalPricePerDay, bool isAvailableForRent)
        {
            this.VehicleId = vehicleId;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.FuelTypeId = fuelTypeId;
            this.PlateNumber = plateNumber;
            this.CarCategoryId = carCategoryId;
            this.RentalPricePerDay = rentalPricePerDay;
            this.IsAvailableForRent = isAvailableForRent;
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

        //public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        //public virtual VehicleCategory CarCategory { get; set; } = null!;

        //public virtual FuleType FuelType { get; set; } = null!;
    

}
}
