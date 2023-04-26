using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0421hw
{
    internal class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime Made { get; set; }
        public int ExpirationDate { get; set; }
        public Product(string type, string name, string manufacturer, DateTime made, int expirationDate)
        {
            Type = type;
            Name = name;
            Manufacturer = manufacturer;
            Made = made;
            ExpirationDate = expirationDate;
        }
    }
}
