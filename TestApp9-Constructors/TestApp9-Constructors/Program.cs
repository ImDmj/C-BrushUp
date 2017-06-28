using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp9_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default Constructor
            //Students student = new Students();
            //Console.WriteLine(student.printdata());
            Console.WriteLine("Enter the number of students");
            int n = Convert.ToInt32(Console.ReadLine());
            Students[] studs = new Students[n];
            int i;
            for (i = 0; i < n; i++)
			{
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                int age = Convert.ToInt32(Console.ReadLine());
            
                studs[i] = new Students(name,age);
			}

            foreach (Students element in studs)
            {
                Console.WriteLine(element.printdata());
            }

            //foreach (int i in n)
            //{
            //    Console.WriteLine(studs[i].printdata());
            //}
            Console.ReadLine();
        }
    }
}
