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
    public class clsCustomerBll
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;




        public clsCustomerDTO CustomerDTO
        {
            get { return (new clsCustomerDTO(this.CustomerId, this.PersonId, this.DriverLicenseNumber)); }
        }

        public clsCustomerDTO CustomerDTO2
        {
            get { return (new clsCustomerDTO(this.CustomerId, this.PersonId, this.FirstName, this.SecondName, this.LastName, this.Phone, this.DriverLicenseNumber)); }
        }

        public int CustomerId { get; set; }

        public int PersonId { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;


        public string DriverLicenseNumber { get; set; } = null!;

        public clsPeopleBll PersonInfo { get; set; } 
        public clsCustomerBll()
        {
            this.CustomerId = -1;
            this.PersonId = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.LastName = "";
            this.Phone = "";
            this.DriverLicenseNumber = "";
            this.PersonInfo = clsPeopleBll.Find(this.PersonId);
            Mode = enMode.AddNew;
        }
        public clsCustomerBll(clsCustomerDTO CustomerDTO, enMode cMode = enMode.AddNew)
        {
            this.CustomerId = CustomerDTO.CustomerId;
            this.PersonId = CustomerDTO.PersonId;
            this.FirstName = CustomerDTO.FirstName;
            this.SecondName = CustomerDTO.SecondName;
            this.LastName = CustomerDTO.LastName;
            this.Phone = CustomerDTO.Phone;
            this.DriverLicenseNumber = CustomerDTO.DriverLicenseNumber;
            this.PersonInfo = clsPeopleBll.Find(CustomerDTO.PersonId);
            Mode = cMode;


        }
        public clsCustomerBll(clsCustomerDTO CustomerDTO2, enMode cMode = enMode.AddNew, int b = 0)
        {
            this.CustomerId = CustomerDTO2.CustomerId;
            this.PersonId = CustomerDTO2.PersonId;

            this.DriverLicenseNumber = CustomerDTO2.DriverLicenseNumber;
            this.PersonInfo = clsPeopleBll.Find(CustomerDTO.PersonId);
            Mode = cMode;
        }
        private bool _AddNewCustomer()
        {
            //call DataAccess Layer 

            this.CustomerId = ClsCustomer.AddCustomer(CustomerDTO);

            return (this.CustomerId != -1);
        }

        private bool _UpdateCustomer()
        {
            return ClsCustomer.UpdatCustomer(CustomerDTO);
        }

        public static clsCustomerBll Find(int ID)
        {

            clsCustomerDTO CustomerDTO2 = ClsCustomer.GetCustomerById(ID);

            if (CustomerDTO2 != null)
            //we return new object of that student with the right data
            {

                return new clsCustomerBll(CustomerDTO2, enMode.Update);
            }
            else
                return null;
        }
     
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCustomer();

            }

            return false;
        }
        public static bool GetCustomerByPersonID(int ID)
        {
            if (ClsCustomer.GetCustomerByPersonID(ID) != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetAllCustomers1()
        {
            return ClsCustomer.GetAllCustomers();
        }
        public static bool IsCustomerExist(int ID)
        {
            return (ClsCustomer.GetCustomerById(ID) != null);
        }
        public static bool DeleteCustomer(int ID)
        {

            return ClsCustomer.DeleteCustomer(ID);
        }
    }
}
