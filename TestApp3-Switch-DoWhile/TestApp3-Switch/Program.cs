using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp3_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //operations of 2 integers
            Console.WriteLine("Enter 1st number");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            Console.WriteLine("1.Additon");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multipication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Exit");
            int op = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("addition of {0} and {1} is {2}", no1, no2, (no1 + no2));
                        break;

                    case 2:
                        Console.WriteLine("Subtraction of {0} and {1} is {2}", no1, no2, (no1 - no2));
                        break;

                    case 3:
                        Console.WriteLine("Product of {0} and {1} is {2}", no1, no2, (no1 * no2));
                        break;

                    case 4:
                        Console.WriteLine("Division of {0} and {1} is {2}", no1, no2, (no1 / no2));
                        break;

                    case 5: break;

                    default:
                        Console.WriteLine("Entered an invalid operator");
                        break;
                }
                Console.WriteLine("\nEnter the operation");
                op = Convert.ToInt32(Console.ReadLine());
            } while (op != 5);
	 
            //Console.ReadLine();
        }
    }
}
