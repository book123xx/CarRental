using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.DTO
{
    public class clsCustomerDTO
    {
       public clsCustomerDTO(int customerId, int personId, string firstName, string secondName, string lastName, string phone, string driverLicenseNumber)
        {
            this.CustomerId = customerId;
            this.PersonId = personId;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Phone = phone;
            this.DriverLicenseNumber = driverLicenseNumber;
        }

        public clsCustomerDTO(int customerId, int personId, string driverLicenseNumber)
        {
            this.CustomerId = customerId;
            this.PersonId = personId;
            this.DriverLicenseNumber = driverLicenseNumber;
        }
        public int CustomerId { get; set; }

        public int PersonId { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;


        public string DriverLicenseNumber { get; set; } = null!;

        //public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        //public virtual Person Person { get; set; } = null!;

        //public virtual User? User { get; set; }
    }


}
