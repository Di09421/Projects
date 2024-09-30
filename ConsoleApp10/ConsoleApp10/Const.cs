using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Const
    {
        public Const(int x)
        {
            Console.WriteLine("1-argument");
        }
        public Const(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
        class D : Const
        {
            public D() : base(10, 20)
            {
                Console.WriteLine("child class constructor");
            }
        }
    }

