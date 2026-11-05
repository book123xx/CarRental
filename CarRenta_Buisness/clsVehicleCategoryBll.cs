using CarRental_DataAccess;
using CarRental_DataAccess.File;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRenta_Buisness1
{
    public class clsVehicleCategoryBll
    {



        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsVehicleCategoryDTO VehicleCategoryDTO
        {
            get { return (new clsVehicleCategoryDTO(this.CategoryId, this.CategoryName)); }
        }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public clsVehicleCategoryBll()
        {
            this.CategoryId = -1;
            this.CategoryName = "";
            Mode = enMode.AddNew;
        }
        public clsVehicleCategoryBll(clsVehicleCategoryDTO VehicleCategoryDTO, enMode cMode = enMode.AddNew)

        {
            this.CategoryId = VehicleCategoryDTO.CategoryId;
            this.CategoryName = VehicleCategoryDTO.CategoryName;

            Mode = cMode;
        }
        public static bool GetFuelTypeById(int id)
        {
            return (clsFuelType.GetFuelTypeById(id) != null);
        }
        public static bool GetFuelTypeByType(string Type)
        {
            return (clsFuelType.GetFuelTypeByType(Type) != null);
        }
        public static clsVehicleCategoryBll? FindByID(int ID)
        {

            clsVehicleCategoryDTO? VehicleCategoryDTO = ClsVehicleCategory.GetVehicleCategoriesByID(ID);

            if (VehicleCategoryDTO != null)
            {

                return new clsVehicleCategoryBll(VehicleCategoryDTO, enMode.Update);
            }
            else
                return null;
        }

        public static clsVehicleCategoryBll FindByCategoryName(string CategoryName)
        {

            clsVehicleCategoryDTO? VehicleCategoryDTO = ClsVehicleCategory.GetVehicleCategoriesByCategoryName(CategoryName);

            if (VehicleCategoryDTO != null)
            {

                return new clsVehicleCategoryBll(VehicleCategoryDTO, enMode.Update);
            }
            else
                return null;
        }


        public static DataTable GetAllVehicleCategories()
        {
            return ClsVehicleCategory.GetAllVehicleCategories();

        }
    }
}
