using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            c.A = 3;
            c.B = 8;
            Console.WriteLine(c.Add());

            Rect r = new Rect();
            r.L = 5;
            r.B = 8;
            Console.WriteLine(r.Area());
        }
    }
}
