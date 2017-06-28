using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp18_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(111, "Raj", 60000);
            //Creating an object of the instance of the delegate..Attaching delegate to the event
            b.LowBalance += new DelLowBalance(ProcessLowBalance);

            Console.WriteLine(b.ToString());

            b.deposit(5000);
            Console.WriteLine(b.ToString());

            b.WithDraw(62000);
            Console.WriteLine(b.ToString());

            Console.ReadLine();
        }

        public static void ProcessLowBalance()
        {
            Console.WriteLine("Min Balance not maintained. Transaction Failed...");
        }
    }
}
