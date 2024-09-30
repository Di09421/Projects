using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, bj = 0, sp = 0, cg = 0, e = 0;
            while (true)
            {
                Console.WriteLine("enter age");
                age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("welcome online voting system");
                    Console.WriteLine("enter 1 for BJP \n enter 2 for CONGRESS \n enter 3 for SP");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                        bj++;
                    else if (opt == 2)
                        cg++;
                    else if (opt == 3)
                        sp++;
                    else
                        Console.WriteLine("NOTA....");
                    e++;
                }
                else
                {
                    Console.WriteLine("not eligible for vote");
                }
                if (e == 4)
                    break;
            }
            Console.WriteLine("total BJP vote is " + bj);
            Console.WriteLine("total SP vote is " + sp);
            Console.WriteLine("total CONGRESS vote is " + cg);
        
            Console.ReadKey();
        }
    }
}
