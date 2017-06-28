using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//When using Class library from somewhere then add it as header library/namespace of the class from the library
using TestApp10_ClassLibrary;

namespace TestApp10_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter the employee number");
            emp.eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee name");
            emp.ename = Console.ReadLine();
            Console.WriteLine("Enter the designation of the employee ");
            emp.desig = Console.ReadLine();
            Console.WriteLine("Enter the basic salary of the employee ");
            emp.bsal = Convert.ToInt32(Console.ReadLine());
            emp.calculate();
            emp.printdetails();
            Console.ReadLine();
           
        }
    }
}
