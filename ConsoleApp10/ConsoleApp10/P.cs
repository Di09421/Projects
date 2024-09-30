using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class P
    {
        public void Samosa()
        {
            Console.WriteLine("aloo ka samosa");
        }
    }
    class C : P
    {
        public void Samosa()
        {
            Console.WriteLine("cheese ka samosa");
            Console.ReadKey();
        }
       
    }
}
