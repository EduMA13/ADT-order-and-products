using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TransportADT
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string gender { get; set; }
        //public int CarsOwn { get; set; }
        public bool susFraud { get; set; }

        public List<Vehicle> Vehicles = new List<Vehicle>();
        public List<License> Licenses = new List<License>();


        public Person(int iD, string name, string surName, int age, string gender, bool susFraud)
        {
            ID = iD;
            Name = name;
            SurName = surName;
            Age = age;
            this.gender = gender;
            this.susFraud = susFraud;
        }
        public void checkData()
        {
            if (Age < 18 | Age > 90)
            {
                Console.WriteLine("You cannot continue because of your age");

                return;

            }
            else
            {
                Console.WriteLine("All in order, you are old enough");

            }
        }
        public void Addlicense(License licenses)
        {
            if (Licenses.Count != 0)
            {

                for (int i = 0; i < Licenses.Count; i++)
                {

                    if (licenses.Type == Licenses[i].Type)
                    {

                        DateTime e = (Licenses[i].ExpirationtD);
                        DateTime n = (DateTime.Now);
                        if (e == n)
                        {
                            Licenses.RemoveAt(i);
                            Licenses.Add(licenses);
                            Console.WriteLine("Your license has been added");
                        }
                        else
                        {
                            Console.WriteLine("There was an error trying to add your license");

                            return;
                        }
                    }
                    else if (Licenses.Count == 0)
                    {

                        Licenses.Add(licenses);
                        Console.WriteLine("Your license has been added");
                    }

                }



            }
            else
            {
                Licenses.Add(licenses);
                Console.WriteLine("Your license has been added");
            }
        }





        //public void cancelCar(License licenses, Vehicle vehicle)
        //{
        //    if (Vehicles.Count > 0)
        //    {

        //        for (int i = 0; i < Licenses.Count; i++)
        //        {

        //            if (vehicle.Vtype == Licenses[i].Type)
        //            {
        //                Vehicles.Remove(vehicle);


        //            }
        //            else

        //                return;
        //        }


        //    }
        //}
        public void checkSus()
        {

            if (Vehicles.Count > 5)
            {
                Console.WriteLine("You are suspected of fraud and we will call the police. ");
                susFraud = true;

            }
            else
            {
                Console.WriteLine("You are not suspected of fraud.");
                return;

            }

        }

        public void addCar(Vehicle vehicle)
        {

            if (gender == "W")
            {
                if (vehicle.color.Equals("Red"))
                {

                    Vehicles.Add(vehicle);
                }
                else
                {
                    return;
                }

            }
            else if (gender == "M")
            {

                if (vehicle.brand.Equals("Ford") | vehicle.brand.Equals("Toyota"))
                {



                    Vehicles.Add(vehicle);


                }
                else
                {
                    return;
                }


            }



        }

        public void cancelCar(License licenses, Vehicle vehicle)
        {
            if (Vehicles.Count != 0)
            {

                for (int i = 0; i < Licenses.Count; i++)
                {

                    if (vehicle.Vtype == Licenses[i].Type)
                    {
                        Vehicles.Remove(vehicle);

                    }
                    else

                        return;
                }


            }
        }
    }
}
