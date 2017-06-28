using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestApp15_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region list<> demo

            List<int> arr = new List<int>();
            arr.Add(10);
            arr.Add(20);
            //arr.Add("Hello"); // string tyoe can't be converted to int so error

            foreach (int i in arr)
            {
                Console.WriteLine("value is {0}",arr[i]);
            }

            #endregion
        }
    }
}
