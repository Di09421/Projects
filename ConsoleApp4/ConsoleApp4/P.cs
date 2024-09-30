using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class P
    {
        public P(int x)
        {
            Console.WriteLine("1-parameter of parent class...");
        }
        public P(int x,int y)
        {
            Console.WriteLine("2-parameter of parent class...");
        }
    }
}
