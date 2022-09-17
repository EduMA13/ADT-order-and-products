using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TransportADT
{
    internal class License
    {
        public string InitialD { get; set; }
        public string ExpirationtD { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }

        public List<Person> persons;

        public List<Vehicle> Vehicles;

        public License()
        {

            this.persons = new List<Person>();

        }
       
        public void checkAge(Person person)
        {
            int i = 0;
            if (person.Age > 90 | person.Age < 18)
            {
                Console.WriteLine("Sorry, you're not eligble");

                return;
            }
            else
            {
                int v = i++;
            }
        }
        public void checkSus(Person person)
        {
            int s = 0;
            if (person.CarsOwn > 5)
            {

                person.susFraud = true;
                Console.WriteLine("You're under arrest");
                return;
            }
            else
            {
               int r= s++;

            }

        }

        public void checkCar(Person person, Vehicle vehicle)
        {
            int f = 0;
            if (person.gender.Equals("W"))
            {

                if (vehicle.color.Equals("Red"))
                {

                   int e= f++;
                }
                else
                {
                    return;

                }

            }

            else if (person.gender.Equals("M")) {

                if (vehicle.brand.Equals("Ford") | vehicle.brand.Equals("Toyota"))
                {

                    int p= f++;

                }
                else {
                    return;

                }
            
            }
        }

        public void licenseG() { 
        
        
        
        }

    }
}

