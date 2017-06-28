using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace TestApp22_Serialization_Deserial
{
    [Serializable]
    public class employee 
    {
        private int empno;
        private string empname;
        private double basicsal;
        
        public int eno
        {
            get { return empno; }
            set { empno = value; }
        }
        public string ename
        {
            get { return empname; }
            set { empname = value; }
        }
       
        public double bsal
        {
            get { return basicsal; }
            set { basicsal = value; }
        }

        public override string ToString()
        {
            return empno + " " + empname + " " + bsal;
        }
    }
}
