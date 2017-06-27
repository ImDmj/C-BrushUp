using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp4_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the table of the number
            int i=0;
            Console.WriteLine("Enter the number");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTable of {0}",no1);
            //for (i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}x{1}={2}",no1,i,(no1*i));
            //}

            while (i<=10)
            {
                Console.WriteLine("{0}x{1}={2}", no1, i, (no1 * i));
                i++;
            }
            Console.ReadLine();
        }
    }
}
