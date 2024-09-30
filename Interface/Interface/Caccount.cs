using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Caccount:Bank
    {
        int ac, bal;
        public int Accno { get => ac; set => ac = value; }
        public int Bal { get => bal; set => bal = value; }

        public void deposit(int a)
        {
            bal = bal + a - 100;
        }

        public void ShowBal()
        {
            Console.WriteLine("now Balance is " + bal);
        }

        public void withd(int a)
        {
            bal = bal - a - 100;
        }

    }
}
