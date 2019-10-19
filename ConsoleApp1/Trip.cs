using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
    class Trip
    {
        private Date start;
        private Date end;
        private string destination;

        public Trip(Date start, Date end, string destination)
        {
            this.start = start ?? throw new ArgumentNullException(nameof(start));
            this.end = end ?? throw new ArgumentNullException(nameof(end));
            this.destination = destination ?? throw new ArgumentNullException(nameof(destination));
        }

        public string getInfo()
        {
            return $"{this.destination} - {this.start.getInfo()} - {this.end.getInfo()}";
        }
    }
}
