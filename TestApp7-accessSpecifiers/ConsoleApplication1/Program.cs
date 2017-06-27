using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date dt = new Date();
            // this works only when the data members of the class are public 
            // if they are private then we need to use the get and set methods
            dt.day = 10;
            dt.month = 3;
            dt.year = 2017;

            Console.WriteLine("{0}/{1}/{2}", dt.day, dt.month, dt.year);

            Console.ReadLine();
        }
    }
}
