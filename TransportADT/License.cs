using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportADT
{
    internal class License
    {
        public DateTime InitialD {get;set;}
        public DateTime ExpirationtD {get;set;}
        public bool Status { get;set;}
        public string Type { get;set;}

        public List<Person> persons;

        public License() { 
        
        this.persons = new List<Person>();
           
        }

        public void addInfo(Person person) {

            if (person.Age > 90) { 
            
    
            
            }
        
        
        
        }


    }



    }

