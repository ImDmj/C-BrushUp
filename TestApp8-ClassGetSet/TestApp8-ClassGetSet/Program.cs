using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp8_ClassGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Date dte = new Date();
            Console.WriteLine("\nEnter the day");
            dte.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the month");
            dte.Month =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the year");
            dte.Year =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(dte.printdate());

            Console.ReadLine();
        }
    }
}
