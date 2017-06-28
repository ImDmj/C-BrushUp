using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp10_ClassLibrary
{
    public class Employee
    {
        private int empno;
        private string empname;
        private string designation;
        private int basicsal;
        private double hra;
        private double pf;
        private int pt;
        private double grosssal;
        private double netsal;

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
        public int bsal
        {
            get { return basicsal; }
            set { basicsal = value; }
        }

        // Since HRA,pfund,tax are read only and we are accepting values from users to set values, 
        //therefore we don't need a set method for this
        public double hr
        {
            get { return hra = 0.5 * basicsal; } // (50/100)*basicsal didn't work 
            // hra = ((double) 50/100)*basical; Typecasting it into double will make it work
        }
        public double pfund
        {
            get { return pf = 0.12 * basicsal; }
        }
        public int tax
        {
            get { return pt = 500; }
        }

        public void calculate() //(double basicsal, ref double grosssal, ref double netsal)            
        {
            grosssal = basicsal + hr;
            netsal = basicsal - pfund - tax;
        }

        public void printdetails()
        {
            // This method is Platform specific as it woll only run on C# platform as it is C3 dependent code 
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

            // the above problem can be avoided if we concatenate all the data and print it.
            // return "Employee number :" + empno; // and soo on
        }
    }
}