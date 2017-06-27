using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // accept 2 numbers and display largest

            Console.WriteLine("Enter 1st number");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());

            if (no1>no2)
            {
                Console.WriteLine("{0} is greater that {1}", no1,no2);
            }
            else if(no2>no1)
            {
                Console.WriteLine("{0} is greater that {1}", no2, no1);
            }
            else
            {
                Console.WriteLine("{0} is equal to {1}", no1, no2);
            }

            Console.ReadLine();

        }
    }
}
