using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0421hw
{
    internal class Employer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get;set; }
        public int ApartmentNumber { get; set; }
        public Employer(string firstName, string lastName, DateTime birth, string phone, string address, string street, int houseNumber, int apartmentNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            Phone = phone;
            Address = address;
            Street = street;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNumber;
        }
    }
}
