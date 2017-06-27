using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp8_ClassGetSet
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        // properties 
        public int Day
        {
            get { return day; }
            set  // set ( int value) - implicit. value given by the user is passed as the parameter to the set()
            {
              if(value>=1 && value<=31)
              {
                  day = value;
              }
            else
              {
                  day = 1;
              }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if( value>=1 && value<=12)
                {
                    month = value;
                }
                else
                {
                    month = 1;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set{ year = value;}
        }

        public string printdate()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
