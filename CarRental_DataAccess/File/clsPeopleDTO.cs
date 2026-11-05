using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess.File
{
    public class clsPeopleDTO
    {
      
        public clsPeopleDTO(int personId, string firstName, string secondName, string lastName, DateTime dateOfBirth, byte gender, string phone, string email, string? imagePath)
        {
            this.PersonId = personId;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;
            this.ImagePath = imagePath;
        }
        public int PersonId { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public byte Gender { get; set; }

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? ImagePath { get; set; }

    //    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    //    public virtual User? User { get; set; }
    //}



}
}
