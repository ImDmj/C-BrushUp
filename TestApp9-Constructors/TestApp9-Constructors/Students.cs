using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TestApp9_Constructors
{
    public class Students
    {
        string name;
        int age;
     
        //Default Constructor
        public Students()
        {
            name = "Manju";
            age = 26;
        }

        //Parameterized Constructor
        public Students( string fn, int a)
        {
            name = fn;
            age = a;
        }

        public string printdata()
        {
            return (name+" "+age);
        }
    }
}
