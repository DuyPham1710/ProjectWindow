using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class Person
    {
        private string iD, name, email, phoneNumber, cccd, gender, address, userName, password;
        private DateTime dateOfBirth;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public Person(string iDValue, string nameValue, string emailValue, string phoneNumberValue, string cccdValue, string genderValue, string addr, string username, string pass, DateTime bornYear)
        {
            ID = iDValue;
            Name = nameValue;
            Email = emailValue;
            PhoneNumber = phoneNumberValue;
            Cccd = cccdValue;
            Gender = genderValue;
            Address = addr;
            UserName = username;
            Password = pass;
            DateOfBirth = bornYear;
        }


    }
}
