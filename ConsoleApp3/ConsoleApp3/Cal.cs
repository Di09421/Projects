using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Cal
    {
        int a, b, c;

        public int A_Val
        {
            //get { return a; }
            set { a = value; }
        }
          public int B_Val
        {
            //get { return b; }
            
            set { b = value; }
        }
        public void Add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
        public void Mult()
        {
            c = a * b;
            Console.WriteLine(c);
        }
    }
}
