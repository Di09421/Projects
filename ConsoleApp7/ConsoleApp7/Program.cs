using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 int values:");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                sum=sum+ a[i];
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }
}
