using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal obj = new Cal();
            obj.A = 8;
            obj.B = 4;
            obj.Add();
            obj.Mult();
            obj.Sub();
            obj.Div();

            Console.ReadKey();
        }
    }
}
