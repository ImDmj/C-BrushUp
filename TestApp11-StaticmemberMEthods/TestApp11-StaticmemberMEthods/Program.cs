using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp11_StaticmemberMEthods
{
    class Program
    {
        static void Main(string[] args)
        {
            Empstatic emp = new Empstatic();

            Empstatic e1 = new Empstatic("Anish", "Manager", 50000);
            Empstatic e2 = new Empstatic("Manish", "Lead", 60000);

            e1.calculate();
            e2.calculate();

            e1.printdetails();
            e2.printdetails();

            Console.ReadLine();
        }
    }
}
