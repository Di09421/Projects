using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Base
    {
        protected int a = 10;
    }
    class C1 : Base
    {
        int a = 20;

        public void m1(int a)
        {
            Console.WriteLine(a);
            Console.WriteLine(base.a);
            Console.WriteLine(this.a);

        }
    }
}
