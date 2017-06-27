using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp5_ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = 10;
            int no2 = 20;
            Console.WriteLine("Values before swap");
            Console.WriteLine("no1 = {0}", no1);
            Console.WriteLine("no1 = {0}", no2);

            //no1,no2 - Actual Parameters
            swap( ref no1,ref no2);

            Console.WriteLine("Values after swap");
            Console.WriteLine("no1 = {0}", no1);
            Console.WriteLine("no1 = {0}", no2);

            Console.ReadLine();
        }

        //a,b - Fomal Parameters
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

// Values will not be swapped as we are just passing the values, hence there will not be nay change to the actual 
// parameters. So we use ref or out to use call by reference and chage the value of original parameters.