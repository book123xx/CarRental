
using CarRental_DataAccess;
using CarRental_DataAccess.File;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRenta_Buisness1
{
    public class clsFuelTypeBll
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsFuleTypeDTO FuleTypeDTO
        {
            get { return (new clsFuleTypeDTO(this.Id,this.FuelType)); }
        }

        public int Id { get; set; }

        public string FuelType { get; set; }
        public clsFuelTypeBll()
        {
            this.Id = -1;
            this.FuelType = "";
            Mode = enMode.AddNew;
        }
        public clsFuelTypeBll(clsFuleTypeDTO FuleTypeDTO, enMode cMode = enMode.AddNew)

        {
            this.Id = FuleTypeDTO.Id;
            this.FuelType = FuleTypeDTO.FuelType;

            Mode = cMode;
        }
        public static bool GetFuelTypeById(int id)
        {
            return (clsFuelType.GetFuelTypeById(id)!= null);
        }
        public static bool GetFuelTypeByType(string Type)
        {
            return (clsFuelType.GetFuelTypeByType(Type)!= null);
        }
        public static clsFuelTypeBll? FindByID(int ID)
        {

            clsFuleTypeDTO? FuleTypeDTO = clsFuelType.GetFuelTypeById(ID);

            if (FuleTypeDTO != null)
            //we return new object of that student with the right data
            {

                return new clsFuelTypeBll(FuleTypeDTO, enMode.Update);
            }
            else
                return null;
        }
        public static clsFuelTypeBll FindByType(string Type)
        {

            clsFuleTypeDTO? FuleTypeDTO = clsFuelType.GetFuelTypeByType(Type);

            if (FuleTypeDTO != null)
            //we return new object of that student with the right data
            {

                return new clsFuelTypeBll(FuleTypeDTO, enMode.Update);
            }
            else
                return null;
        }

        public static DataTable GetAllFuelTypes()
        {
            return clsFuelType.GetAllFuelTypes();

        }

    }
  


}
