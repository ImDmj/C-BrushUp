using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestApp14_NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arraylist demo

            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add("Hello");
            arr.Add(30.25);

            arr.Remove(20);
            arr.Clear();

            #endregion

            #region queue demo

            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue('a');
            q.Enqueue("Hello");
            q.Enqueue(DateTime.Now);

            #endregion

            #region stack demo

            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(10.345);
            st.Push(true);
            st.Push(DateTime.Now);
            st.Push("Hello");

            Console.WriteLine("Element popped {0}", st.Pop());
            Console.WriteLine("Element popped {0}", st.Pop());

            #endregion

            #region hashtable demo

            Hashtable ht = new Hashtable(); // type is dictionary entry
            ht.Add(1, 2);
            ht.Add('a', "C#");
            ht.Add('b', "asp.net");
            ht.Add(2, DateTime.Now);

            ht.Remove('a');

            Console.WriteLine("no. of elements : {0}", ht.Count);

            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine(d.Key + ":" + d.Value);
            //}

            ht.Clear(); // removes all the elements of the hashtable
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
            Console.WriteLine("Clear");
            #endregion

            Console.ReadLine();
        }
    }
}
