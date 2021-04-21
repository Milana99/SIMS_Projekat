
using System;

namespace Bolnica.Model
{
   public class User
   {
      public String Name { get; set; }
        public String Surname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public Gender Gender { get; set; }
        public long Jmbg { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }

        public User(String newName, String newSurname, String newUsername, String newPassword, String newPhoneNumber, String newEmail,
            Gender newGender, long newJmbg, DateTime newDateOfBirth, String newAddress)
        {
            Name = newName;
            Surname = newSurname;
            Username = newUsername;
            Password = newPassword;
            PhoneNumber = newPhoneNumber;
            Email = newEmail;
            Gender = newGender;
            Jmbg = newJmbg;
            DateOfBirth = newDateOfBirth;
            Address = newAddress;
        }
        public User(String newName, String newSurname, String newUsername, String newPhoneNumber, String newEmail,
            Gender newGender, long newJmbg, DateTime newDateOfBirth, String newAddress)
        {
            Name = newName;
            Surname = newSurname;
            Username = newUsername;
            Password = "1234";
            PhoneNumber = newPhoneNumber;
            Email = newEmail;
            Gender = newGender;
            Jmbg = newJmbg;
            DateOfBirth = newDateOfBirth;
            Address = newAddress;
        }
        public User(String newUsername)
        {
            Username = newUsername;
        }

    }
}