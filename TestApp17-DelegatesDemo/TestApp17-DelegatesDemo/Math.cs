using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp17_DelegatesDemo
{
    public class Math
    {

        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void multi(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public string UpperCase(string s)
        {
            Console.WriteLine("Upper Case");
            return s.ToUpper();
        }

        public string LowerCase(string s)
        {
            Console.WriteLine("Lower Case");
            return s.ToLower();
        }
    }
}
