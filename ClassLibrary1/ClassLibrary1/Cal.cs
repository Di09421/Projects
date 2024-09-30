using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cal
    {
        int a, b, c;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public int Add()
        {
            return a + b;
        }

        public int Mult()
        {
            return a * b;
        }
    }
}

