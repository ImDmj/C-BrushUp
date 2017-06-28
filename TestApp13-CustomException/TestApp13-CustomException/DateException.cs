using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp13_CustomException
{
    class DateException
    {
        private int day;
        private int month;
        private int year;

        // properties 
        public int Day
        {
            get { return day; }
            set  
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    //throw exception
                    throw new InvalidDateException("Invalid Day. Try again..");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    //throw exception
                    throw new InvalidDateException("Invalid Month. Try again..");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string printdate()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
