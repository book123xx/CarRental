using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.File
{
    public class clsFuleTypeDTO
    {
        public clsFuleTypeDTO(int iD,string fuelType)
        {
            this.Id = iD;
            this.FuelType = fuelType;
        }
    
        public int Id { get; set; }

        public string FuelType { get; set; } = null!;

        //public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    


}
}
