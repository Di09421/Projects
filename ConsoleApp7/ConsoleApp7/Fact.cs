using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Fact
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter 5 int values");
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("The entered integers are:");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"\n factorial for {a[i]}:");
                int fact = 1;
                for (int j = 1; j <= 5; j++)
                {
                    fact = fact * a[i];
                    Console.WriteLine(fact + "*" + a[i]+"="+fact);
                }
            }
            Console.ReadKey();
        }
    }
}
