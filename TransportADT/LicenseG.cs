using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportADT
{
    internal class LicenseG
    {
        public List<Person> People;
        public List<Vehicle> Vehicles;
        public List<License> Licenses;

        public LicenseG()
        {
            this.People = new List<Person>();
        }
    
    }
}
