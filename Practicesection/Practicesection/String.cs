using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practicesection
{
    internal class String
    {
        static void Main(string[] args)
        {

            int[] n = { 8, -1, -2, 5, 6, 0, 8, -1 };

            int positiveSum = 0;
            int positiveCount = 0;
            int negativeSum = 0;
            int negativeCount = 0;
            int totalSum = 0;
            int totalCount = 0;

            foreach (int num in n)
            {
                totalSum += num;
                totalCount++;

                if (num > 0)
                {
                    positiveSum += num;
                    positiveCount++;
                }
                else if (num < 0)
                {
                    negativeSum += num;
                    negativeCount++;
                }
            }

            int avgPost = positiveCount > 0 ? positiveSum / positiveCount : 0;
            int avgNeg = negativeCount > 0 ? negativeSum / negativeCount : 0;
            int avg = totalCount > 0 ? totalSum / totalCount : 0;

            Console.WriteLine("Negative Numbers Sum: " + negativeSum);
            Console.WriteLine("Positive Numbers Sum: " + positiveSum);
            Console.WriteLine("Avg of Negative Numbers: " + avgNeg);
            Console.WriteLine("Avg of Positive Numbers: " + avgPost);
            Console.WriteLine("Overall Avg: " + avg);

            Console.ReadLine();
        }


    }
        }
