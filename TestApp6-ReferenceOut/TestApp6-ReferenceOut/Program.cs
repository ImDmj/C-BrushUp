using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp6_ReferenceOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 5;
            double area, circum;

            calculate(r, out area, out circum);

            Console.WriteLine("Area = {0}",area);
            Console.WriteLine("Circumference = {0}", circum);

            Console.ReadLine();

        }

        static void calculate(int r, out double a, out double c)
        {
            a = 3.14 * r * r;
            c = 2 * 3.14 * r;
        }
    }
}
