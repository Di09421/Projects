using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class C:P
    {
        public C():base(10,20)
        {
            Console.WriteLine("default const of child class...");
        }
    }
}
