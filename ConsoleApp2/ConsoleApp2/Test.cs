using System;
namespace ConsoleApp2
{
    internal class Test
    {
        readonly int a;
        int b;

       Test(int x,int y)
        {
            a = x;
            b = y;
        }
        void m1()
        {
            b = 600;
        }
        static void Main(string[] args)
        {
            Test t = new Test(10, 100);
            Console.WriteLine(t.b);
            t.m1();
            Console.WriteLine(t.b);

            Test t1 = new Test(20,200);
            Test t2 = new Test(30,300);
            Console.ReadKey();

        }
    }
}
