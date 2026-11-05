using System;

namespace CarRental_DataAccess.DTO
{
    public class clsUserDTO
    {
        public clsUserDTO(int userId, int personId, string userName, byte[] passwordHash, byte[] passwordSalt, int iterations, bool isActive)
        {
            this.UserId = userId;
            this.PersonId = personId;
            this.UserName = userName;
            this.PasswordHash = passwordHash;
            this.PasswordSalt = passwordSalt;
            this.Iterations = iterations;
            this.IsActive = isActive;
        }

        public clsUserDTO(int userId, string userName, int personId, bool isActive)
        {
            this.UserId = userId;
            this.PersonId = personId;
            this.UserName = userName;
            this.IsActive = isActive;
        }

        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
      
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public int Iterations { get; set; }
        public bool IsActive { get; set; }
    }
}