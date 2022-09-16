using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportADT
{
    internal class Register
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Vehicle V1 = new Vehicle();
            License L1 = new License();

            P1.Name = "Juan";
            P1.SurName = "Vasquez";
            P1.ID = 1234;
            P1.age = 19;
            P1.gender = "M";

            V1.Vtype = "SUV";
            V1.description = "bLABLA";
            V1.brand = "Ford";
            V1.year = 2019;
            V1.color = "Red";

            L1.Type = "Car";


        }
    }
}
