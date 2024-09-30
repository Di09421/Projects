using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal partial class Cal
    {
        public void Sub()
        {
            c = a - b;
            Console.WriteLine("subtraction is :" + c);
        }
        public void Div()
        {
            c = a / b;
            Console.WriteLine("division is :" + c);
        }
    }
}
