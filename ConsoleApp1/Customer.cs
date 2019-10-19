using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
    class Customer
    {
        private string name;
        private Address address;
        private Trip trip;

        public Customer(string name)
        {
            this.name = name;
        }

        public void setAddress(Address address)
        {
            this.address = address;
        }
        public void assignTrip(Trip trip)
        {
            this.trip = trip;
        }

        public string getInfo()
        {
            return $"Name: {this.name}\nAddress: {this.address.getInfo()}\nTrip: {this.trip.getInfo()}";
        }
    }
}
