using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp18_Events
{
    public delegate void DelLowBalance();

    public class Bank
    {
        private int accno;
        private string name;
        private int balance;

        //declare an event
        public event DelLowBalance LowBalance;

        public Bank()
        {
            accno = 1;
            name = "Sam";
            balance = 50000;
        }

        public Bank(int a, string n, int b)
        {
            accno = a;
            name = n;
            balance = b;
        }

        public void deposit(int amt)
        {
            balance += amt;
        }

        public void WithDraw(int amt)
        {
            if (balance-amt>=5000)
            {
                balance -= amt;
            }
            else
            {
                //notify i.e, raise an event...
                LowBalance();
            }
        }

        public override string ToString()
        {
            return accno+ " " + name + " " + balance;
        }

    }
}
