using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp16_GenericMethod
{
    public class MyStack<t>
    {
        t[] arr;
        int top;

        public MyStack(int size)
        {
            arr = new t[size];
            top = 0;
        }

        public void Push(t element)
        {
            arr[top++] = element;
        }

        public t Pop()
        {
            return arr[--top];
        }
    }
}
