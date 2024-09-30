using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter 5 int values:");
            for (int i = 0; i < a.Length; i++)
          
                a[i] = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < a.Length; i++)
           Array.Sort(a);
            foreach(int x in a)
                Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
