using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp13_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateException dte = new DateException();
                Console.WriteLine("\nEnter the day");
                dte.Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the month");
                dte.Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the year");
                dte.Year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(dte.printdate());
            }
            catch(InvalidDateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
