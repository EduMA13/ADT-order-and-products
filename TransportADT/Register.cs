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
            P1.Age = 19;
            P1.gender = "M";
            P1.CarsOwn = 0;
            P1.susFraud = false;

            V1.Vtype = "SUV";
            V1.description = "8-passenger SUV ";
            V1.brand = "Ford";
            V1.year = 2019;
            V1.color = "Red";
            V1.wheels = 4;

            L1.Type = "Car";
            L1.InitialD = "17/9/2018";
            L1.ExpirationtD = "24/12/2022";

            L1.checkAge(P1);
            L1.checkSus(P1);
            L1.checkCar(P1,V1);


        }
    }
}
