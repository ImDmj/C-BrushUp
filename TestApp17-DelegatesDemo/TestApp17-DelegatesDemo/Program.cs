using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp17_DelegatesDemo
{
    public delegate void mydelegate(int a, int b);
    public delegate string mystringdelegate(string s);

    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            Console.Clear();
            //Instantiating Delegate
            //Mydelegate d = new MydelegateAdd(m.add);
            //d += m.multi; // multicast delegates
            //d += m.sub;
            ////Invoking Delegates in two ways
            //d(10,20);
            //d.Invoke(10,20);

            mystringdelegate str = new mystringdelegate(m.UpperCase);
            //str += m.UpperCase;
            str += m.LowerCase;
            //Console.WriteLine(str("hElLo"));
            // Only printing hello for the lowercase and not uppercase. In case of 
            // multicast delegate, recommneded return is void, like we did for math functions.

            Delegate[] del = str.GetInvocationList();
            foreach (Delegate d in del)
            {
               Console.WriteLine((d as mystringdelegate).Invoke("hello"));
            }

            Console.ReadLine();
        }
    }
}
