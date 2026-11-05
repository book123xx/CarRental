using CarRental_DataAccess;
using CarRental_DataAccess.File;
using System.Data;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRenta_Buisness
{
    public class clsUserBll
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsUserDTO UserDTO2
        {
            get { return new clsUserDTO(this.UserId, this.PersonId, this.UserName, this.PasswordHash, this.PasswordSalt, this.Iterations, this.IsActive); }
        }

        public clsUserDTO UserDTO
        {
            get { return new clsUserDTO(this.UserId, this.UserName, this.PersonId, this.IsActive); }
        }

        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Phone { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public int Iterations { get; set; } = 100000;
        public bool IsActive { get; set; }
        public clsPeopleBll Personinfo { get; set; }
        public string PlainPassword { get; set; } = string.Empty;

        public clsUserBll()
        {
            this.UserId = -1;
            this.PersonId = -1;
            this.UserName = string.Empty;
            this.PasswordHash = null!;
            this.PasswordSalt = null!;
          
            this.PlainPassword = string.Empty;
            this.IsActive = true;
            this.Personinfo = null!;
        }

        public clsUserBll(clsUserDTO userDTO, enMode cMode = enMode.AddNew)
        {
            if (userDTO != null)
            {
                this.UserId = userDTO.UserId;
                this.PersonId = userDTO.PersonId;
                this.UserName = userDTO.UserName;
                this.PasswordHash = userDTO.PasswordHash;
                this.PasswordSalt = userDTO.PasswordSalt;
                this.Iterations = userDTO.Iterations > 0 ? userDTO.Iterations : 100000;
                this.IsActive = userDTO.IsActive;
                this.Personinfo = clsPeopleBll.Find(userDTO.PersonId);
            }
            Mode = cMode;
        }

        public static byte[] GenerateSalt(int length = 16)
        {
            byte[] bytes = new byte[length];
            RandomNumberGenerator.Fill(bytes);
            return bytes;
        }

        public static byte[] HashPasswordWithSalt(string password, byte[] salt, int iterations = 100000)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(
                password: password,
                salt: salt,
                iterations: iterations,
                hashAlgorithm: HashAlgorithmName.SHA256
            );
            return pbkdf2.GetBytes(32);
        }

        public static bool VerifyPassword(string enteredPassword, byte[] storedHash, byte[] storedSalt, int iterations)
        {
            if (storedHash == null || storedSalt == null)
                return false;

            byte[] computedHash = HashPasswordWithSalt(enteredPassword, storedSalt, iterations);
            return CryptographicOperations.FixedTimeEquals(computedHash, storedHash);
        }

        private bool _AddNewUser()
        {
            this.PasswordSalt = GenerateSalt(16);
            this.PasswordHash = HashPasswordWithSalt(this.PlainPassword, this.PasswordSalt, this.Iterations);

            this.UserId = ClsUser.AddNewUser(UserDTO2);

            return (this.UserId != -1);
        }
 private bool _UpdateUser()
        {
            if (!string.IsNullOrEmpty(this.PlainPassword))
            {
                this.PasswordSalt = GenerateSalt(16);
                this.PasswordHash = HashPasswordWithSalt(this.PlainPassword, this.PasswordSalt, this.Iterations);
            }

            return ClsUser.UpdateUser(UserDTO2);
        }

        public static clsUserBll? Find(int ID)
        {
            clsUserDTO? userDTO = ClsUser.GetUserById(ID);

            if (userDTO != null)
            {
                return new clsUserBll(userDTO, enMode.Update);
            }
            else
                return null;
        }

        public static clsUserBll? FindByUsernameAndPassword(string UserName, string PlainPassword)
        {
            clsUserDTO? dto = ClsUser.GetUserInfoByUsername(UserName);

            if (dto != null)
            {
                if (VerifyPassword(PlainPassword, dto.PasswordHash, dto.PasswordSalt, dto.Iterations))
                {
                    return new clsUserBll(dto, enMode.Update);
                }
            }
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool CheckPersonExists(int ID)
        {
            return ClsUser.CheckPersonExists(ID);
        }

        public static bool isUserNameExist(string name)
        {
            return ClsUser.GetUserInfoByUsername(name) != null;
        }

        public static bool isUserExist(int ID)
        {
            return ClsUser.GetUserInfoByPersonID(ID) != null;
        }

        public static bool DeleteUser(int ID)
        {
            return ClsUser.DeleteUser(ID);
        }

        public static DataTable GetAllUsers()
        {
            return ClsUser.GetAllUsers();
        }
    }
}