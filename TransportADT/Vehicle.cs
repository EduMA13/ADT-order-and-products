using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportADT
{
    internal class Vehicle
    {
     public string Vtype { get; set; }
        public int year { get; set; }
        public string brand { get; set; }
        public string description   { get; set; }
        public int wheels { get; set; }
        public string color { get; set; }

        public Vehicle(string vtype, int year, string brand, string description, int wheels, string color)
        {
            Vtype = vtype;
            this.year = year;
            this.brand = brand;
            this.description = description;
            this.wheels = wheels;
            this.color = color;
        }
    }
}
