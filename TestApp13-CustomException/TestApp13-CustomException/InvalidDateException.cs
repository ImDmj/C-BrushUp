using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp13_CustomException
{
    public class InvalidDateException : ApplicationException
    {
        public InvalidDateException(string str) : base (str)
        {

        }
    }
}
