using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saccount s = new Saccount();
            s.Accno = 211;
            s.Bal = 6000;
            s.deposit(5000);
            s.withd(3000);
            s.ShowBal(); 

            Caccount c = new Caccount();
            c.Accno = 411;
            c.Bal = 6000;
            c.deposit(4000);
            c.withd(1000);
            c.ShowBal();

            Console.ReadKey();
        }
    }
}
