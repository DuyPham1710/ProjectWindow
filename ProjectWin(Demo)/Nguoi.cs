using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class Nguoi
    {
        private int iD;
        private string fullName, email, phoneNumber, cccd, gender, address, userName, password, position;
        private byte[] avt;
        private DateTime dateOfBirth;

        public int ID { get => iD; set => iD = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Position { get => position; set => position = value; }
        public byte[] Avt { get => avt; set => avt = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public Nguoi(int iDValue, string nameValue, string emailValue, string phoneNumberValue, string cccdValue, string genderValue, string addr, string username, string pass, string pos, DateTime bornYear, byte[] avtValue)
        {
            ID = iDValue;
            FullName = nameValue;
            Email = emailValue;
            PhoneNumber = phoneNumberValue;
            Cccd = cccdValue;
            Gender = genderValue;
            Address = addr;
            UserName = username;
            Password = pass;
            Position = pos;
            DateOfBirth = bornYear;
            Avt = avtValue;
        }

        public Nguoi(int iDValue, string nameValue, string emailValue, string phoneNumberValue, string cccdValue, string genderValue, string addr, string username, string pass, DateTime bornYear, byte[] avtValue)
        {
            ID = iDValue;
            FullName = nameValue;
            Email = emailValue;
            PhoneNumber = phoneNumberValue;
            Cccd = cccdValue;
            Gender = genderValue;
            Address = addr;
            UserName = username;
            Password = pass;
            DateOfBirth = bornYear;
            Avt = avtValue;
        }
    }
}
