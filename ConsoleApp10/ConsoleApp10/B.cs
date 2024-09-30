using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class B
    {
        public void m1()
        {
            Console.WriteLine("m1-p");
        }
    }
    class A : B
    {
        public void m2()
        {
            base.m1();
            this.m1();
            m1();
        }
        public void m1()
        {
            Console.WriteLine("m1-c");
        }

    }
}
