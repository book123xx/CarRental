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
    public class clsPeopleBll
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsPeopleDTO PeopleDTO
        {
            get { return (new clsPeopleDTO(this.PersonId, this.FirstName, this.SecondName, this.LastName, this.DateOfBirth, this.Gender, this.Phone, this.Email, this.ImagePath)); }
        }
        public int PersonId { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + LastName; }
        }

        public DateTime DateOfBirth { get; set; }


        public byte Gender { get; set; }

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? ImagePath { get; set; }

        public clsPeopleBll()
        {

            this.PersonId = -1;
            this.FirstName = "";
            this.SecondName ="";
            this.LastName ="";
            this.DateOfBirth = DateTime.Now;
            this.Phone ="";
            this.Email = "";
            this.ImagePath ="";
            Mode = enMode.AddNew;
        }
        public clsPeopleBll(clsPeopleDTO PeopleDTO, enMode cMode = enMode.AddNew)
        {
            this.PersonId = PeopleDTO.PersonId;
            this.FirstName = PeopleDTO.FirstName;
            this.SecondName = PeopleDTO.SecondName;
            this.LastName = PeopleDTO.LastName;
            this.DateOfBirth = PeopleDTO.DateOfBirth;
            this.Gender = PeopleDTO.Gender;
            this.Phone = PeopleDTO.Phone;
            this.Email = PeopleDTO.Email;
            this.ImagePath = PeopleDTO.ImagePath;
            Mode = cMode;
        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonId = ClsPeople.AddPerson(PeopleDTO);

            return (this.PersonId != -1);
        }
        private bool _UpdatePerson()
        {
            return ClsPeople.UpdatePerson(PeopleDTO);
        }

        public static clsPeopleBll Find(int ID)
        {

            clsPeopleDTO PeopleDTO = ClsPeople.GetPersonById(ID);

            if (PeopleDTO != null)
            //we return new object of that student with the right data
            {

                return new clsPeopleBll(PeopleDTO, enMode.Update);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }
        public static DataTable GetAllPeople()
        {
            return ClsPeople.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {

            return ClsPeople.DeletePerson(ID);
        }
    }
}



