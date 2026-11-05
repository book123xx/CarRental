using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.DTO
{
   
    public  class clsVehicleCategoryDTO
    {
        public clsVehicleCategoryDTO(int categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        //public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    

}
}
