using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal obj = new Cal();
            obj.A = 3;
            obj.B = 4;
            Console.WriteLine(obj.Add());
            Console.WriteLine(obj.Mult());

            Rect r1 = new Rect();
            r1.L = 5;
            r1.B = 6;
            Console.WriteLine(r1.Area());
            Console.WriteLine(r1.Peri());
            Console.ReadKey();

        }
    }
}
