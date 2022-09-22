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
        public DateTime InitialD { get; set; }
        public DateTime ExpirationtD { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
        public Person person { get; set; }

        public License(DateTime initialD, DateTime expirationtD, bool status, string type)
        {
            InitialD = initialD;
            ExpirationtD = expirationtD;
            Status = status;
            Type = type;
        }
    }
}

    


