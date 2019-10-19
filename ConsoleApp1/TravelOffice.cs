using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
    class TravelOffice
    {
        static void Main(string[] args)
        {
            Address address = new Address("Poznańska", "60-001", "Poznań");
            Trip trip = new Trip(new Date(2019, 10, 19), new Date(2019, 10, 20), "Poznań");

            Customer customer = new Customer("Firstname Lastname");
            customer.setAddress(address);
            customer.assignTrip(trip);
            
            Console.WriteLine(customer.getInfo());
            Console.ReadKey();
        }
    }
}
