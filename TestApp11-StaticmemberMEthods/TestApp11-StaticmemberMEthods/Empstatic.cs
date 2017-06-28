using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp11_StaticmemberMEthods
{
    class Empstatic
    {
        private int empno;
        private string empname;
        private string designation;
        private double basicsal;
        private double hra;
        private double pf;
        private int pt;
        private double grosssal;
        private double netsal;
        private static int countofobject;

         public Empstatic()
        {
            countofobject++;
            empno = 0;
            empname = "Manju";
            designation = "engineer";
            basicsal = 40000;
        }

         public Empstatic(string ename, string designa, double bsal)
        {
            countofobject++;
            empno = countofobject;
            empname = ename;
            designation = designa;
            basicsal = bsal;
        }

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
        public string desig
        {
            get { return designation; }
            set { designation = value; }
        }
        public double bsal
        {
            get { return basicsal; }
            set { basicsal = value; }
        }

        public double hr
        {
            get { return hra = 0.5 * basicsal; } 
        }
        public double pfund
        {
            get { return pf = 0.12 * basicsal; }
        }
        public int tax
        {
            get { return pt = 500; }
        }

        public void calculate()             
        {
            grosssal = basicsal + hr;
            netsal = basicsal - pfund - tax;
        }

        public void printdetails()
        {
            Console.WriteLine("\n---- Details ----\n");
            Console.WriteLine("Employee number :      {0}", empno);
            Console.WriteLine("Name :                 {0}", empname);
            Console.WriteLine("Designation:           {0}", designation);
            Console.WriteLine("Basic Salary :         {0}", basicsal);
            Console.WriteLine("HRA :                  {0}", hra);
            Console.WriteLine("Provident fund :       {0}", pf);
            Console.WriteLine("Tax :                  {0}", pt);
            Console.WriteLine("Gross salary :         {0}", grosssal);
            Console.WriteLine("Net Salary :           {0}", netsal);
        }
        public static void printcount()
        {
            Console.WriteLine("No. Of Employees {0}", Empstatic.countofobject);
        }
    }
}
