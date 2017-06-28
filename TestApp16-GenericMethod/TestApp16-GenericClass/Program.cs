using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestApp16_GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region genericMethodDemo

            MyStack<string> s = new MyStack<string>(3);
            s.Push("aaa");
            s.Push("bbb");
            s.Push("ccc");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            MyStack<int> st = new MyStack<int>(3);
            st.Push(10);
            st.Push(20);
            st.Push(30);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            #endregion

            #region genericStackdemo
            int no1=10, no2=20;
            string s1="HELLO", s2="WORLD";

            swap<int>(ref no1, ref no2);
            swap<string>(ref s1, ref s2);

            Console.WriteLine("no1={0}, no2={1}", no1, no2);
            Console.WriteLine("s1={0} , s2={1}", s1, s2);
            #endregion

            #region foreachDemo

            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            arr.Add(40);
            arr.Add(50);

            Console.WriteLine("Count ={0}", arr.Count);
            Console.WriteLine("Capacity ={0}",arr.Capacity);


            // Internal Working of foreach i.e, IEnumerator
            IEnumerator obj = arr.GetEnumerator();
            while(obj.MoveNext())
            {
                Console.WriteLine(obj.Current);
            }

            //foreach( var o in arr)
            //{
            //    Console.WriteLine(0);
            //}

            #endregion

            Console.ReadLine();
        }

        static void swap<t>(ref t a, ref t b)
        {
            t temp = a;
            a = b;
            b = temp;
        }
    }
}
