using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicesection
{
    internal class first
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string input =Console.ReadLine();
            Console.WriteLine("Enter a Character a remove:");
            char remove = Console.ReadLine()[0];
            string result = "";
            foreach(char ch in input)
            {
                if(ch!=remove)
                {
                    result += ch;
                }
            }
            Console.Write("String after removing'" + remove + "': " + result);
            Console.ReadLine();

            

        }
    }
}