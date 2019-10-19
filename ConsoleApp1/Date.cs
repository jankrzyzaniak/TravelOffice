using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
    class Date
    {
        private int Year;
        private int Month;
        private int Day;

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public string getInfo()
        {
            return $"{this.Year}-{this.Month}-{this.Day}";
        }
    }
}
