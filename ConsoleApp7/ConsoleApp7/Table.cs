using System;

namespace ConsoleApp7
{
    internal class Table
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 integer values:");
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("The entered integers are:");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"\nMultiplication table for {a[i]}:");
                for (int j = 1; j <= 10; j++)
                {
                    int table = a[i] * j;
                    Console.WriteLine($"{a[i]} * {j} = {table}");
                }
            }
            Console.ReadKey();
        }
    }
}
