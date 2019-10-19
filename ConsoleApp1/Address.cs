using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
    class Address
    {
        private string street;
        private string zip;
        private string city;

        public Address(string street, string zip, string city)
        {
            this.street = street;
            this.zip = zip;
            this.city = city;
        }

        public string getInfo()
        {
            return $"{this.street}, {this.zip}, {this.city}";
        }
    }
}
