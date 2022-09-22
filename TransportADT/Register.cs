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
        Register register = new Register();
        Person Fperson = new Person(1234, "Sobastian", "Ramirez", 91, "M",false);
        Vehicle Fvehicle = new Vehicle("Car", 2018, "Ford", "Very fast car", 4, "Purple");
            //Vehicle svehicle = new Vehicle("Car", 2018, "Nissan", "0-100 speed in 10 seconds", 4, "Red");
            //Vehicle tvehicle = new Vehicle("Car", 2018, "Toyota", "Electric car with a 500 km range", 4, "Black");
            //Vehicle rvehicle = new Vehicle("Car", 2018, "Peugot", "Sports car", 4, "Purple");
            //Vehicle zvehicle = new Vehicle("Car", 2018, "us", "Description", 4, "Blue");
            //Vehicle xvehicle = new Vehicle("Car", 2018, "ssss", "Description", 4, "Brown");
            //Vehicle qvehicle = new Vehicle("Car", 2018, "asdasd", "Description", 4, "Yellow");
        License license = new License(new DateTime (18 / 06 / 2015), new DateTime(18 / 06 / 2019), true, "Car");
        License dlicense = new License(new DateTime(18 / 06 / 2015), new DateTime(21 /  09/ 2022), true, "Car");

            Fperson.checkData();
            Fperson.addCar(Fvehicle);
            Fperson.Addlicense(license);
            Fperson.Addlicense(dlicense);
            //Fperson.addCar(svehicle);
            //Fperson.addCar(tvehicle);
            //Fperson.addCar(rvehicle);
            //Fperson.addCar(zvehicle);
            //Fperson.addCar(xvehicle);
            //Fperson.addCar(qvehicle);
            Fperson.cancelCar(license, Fvehicle);
           
            Console.WriteLine( "Number of licenses added: "+Fperson.Licenses.Count);
            Console.WriteLine("Number of vehicles added:"+Fperson.Vehicles.Count);
            Fperson.checkSus();


            Console.ReadLine();

      

        }
    }
}
