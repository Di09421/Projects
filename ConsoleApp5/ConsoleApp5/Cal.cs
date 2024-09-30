using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal partial class Cal
    {
        int a, b, c;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public void Add()
        {
            c = a + b;
            Console.WriteLine("sum is :"+c);
        }
        public void Mult()
        {
            c = a * b;
            Console.WriteLine("multiplication is :"+c);
        }
    }
}
