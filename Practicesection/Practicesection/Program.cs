using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicesection
{
    internal class Program
    {
        //static double TaxCalculator(double grossSalary, double totalSavings)
        //{

        //    double maxSavingsDeduction = 100000;
        //    double savingsDeduction = totalSavings > maxSavingsDeduction ? maxSavingsDeduction : totalSavings;
        //    double taxableIncome = grossSalary - savingsDeduction;
        //    double tax = 0;
        //    if (taxableIncome <= 100000)
        //    {
        //        tax = 0;
        //    }
        //    else if (taxableIncome > 100000 && taxableIncome <= 200000)
        //    {
        //        tax = (taxableIncome - 100000) * 0.10;
        //    }
        //    else if (taxableIncome > 200000 && taxableIncome <= 500000)
        //    {
        //        tax = (100000 * 0.10) + (taxableIncome - 200000) * 0.20;
        //    }
        //    else if (taxableIncome > 500000)
        //    {
        //        tax = (100000 * 0.10) + (300000 * 0.20) + (taxableIncome - 500000) * 0.30;
        //    }
        //    return tax;
        //}

        //static void CalculateTaxOnSalary()
        //{
        //    Console.Write("Enter your gross salary: ");
        //    double grossSalary = double.Parse(Console.ReadLine());
        //    Console.Write("Enter your total savings: ");
        //    double totalSavings = double.Parse(Console.ReadLine());
        //    double tax = TaxCalculator(grossSalary, totalSavings);
        //    Console.WriteLine("The calculated tax on your income is: Rs. " + tax);
        //}

        //static int SumDigits(int number)
        //{
        //    int sum = 0;

        //    // Handle negative numbers
        //    number = Math.Abs(number);

        //    // Loop to extract each digit and add to the sum
        //    while (number != 0)
        //    {
        //        sum += number % 10;  // Get the last digit
        //        number /= 10;        // Remove the last digit
        //    }

        //    return sum;
        //}
        static void Main(string[] args)
        {
            // Console.Write("enter a marks :");
            //int marks=int.Parse(Console.ReadLine());

            // string grade;
            // if(marks<25)
            // {
            //     grade = "F";
            // }
            // else if(marks>=25 && marks<45)
            // {
            //     grade = "E";
            // }
            // else if (marks >= 45 && marks < 50)
            // {
            //     grade = "D";
            // }
            // else if (marks >= 50 && marks < 60)
            // {
            //     grade = "C";
            // }
            // else if (marks >= 60 && marks < 80)
            // {
            //     grade = "B";
            // }
            // else if (marks >= 80)
            // {
            //     grade = "A";
            // }
            // else
            // {
            //     grade = "Invalid marks";
            // }
            // Console.WriteLine("The grade is:" + grade);



            //Console.Write("Enter a age:");
            //int age=int.Parse(Console.ReadLine());

            //if(age < 20 || age > 60)
            //{
            //    Console.WriteLine("Error: Invalid age");
            //}

            //Console.Write("Enter a gender(M for Male and F for Female):");
            //char gender = char.ToUpper(Console.ReadKey().KeyChar);
            //Console.WriteLine();

            //Console.Write("Enter a marital status(Y or N):");
            //char marital = char.ToUpper(Console.ReadKey().KeyChar);
            //Console.WriteLine();

            //if (gender == 'F')
            //{
            //    Console.WriteLine("You will work only in urban areas.");
            //}
            //else if (gender == 'M')
            //{
            //    if (age >= 20 && age <= 40)
            //    {
            //        Console.WriteLine("You may work anywhere.");
            //    }
            //    else if (age > 40 && age <= 60)
            //    {
            //        Console.WriteLine("You will work only in urban areas.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input for gender.");
            //}

            //CalculateTaxOnSalary();

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //// Call SumDigits and display the result
            //int result = SumDigits(number);
            //Console.WriteLine("The sum of the digits is: " + result);

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string replacedAString = ReplaceLowerA(input);
            string initials = GetInitials(input);
            string oddEvenString = OddEvenUppercase(input);
            Console.WriteLine("Replaced lowercase 'a' (except after space): " + replacedAString);
            Console.WriteLine("Initials: " + initials);
            Console.WriteLine("Odd letters uppercase, even letters lowercase: " + oddEvenString);
        }
        static string ReplaceLowerA(string str)
        {
            char[] result = str.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 'a' && (i == 0 || result[i - 1] != ' '))
                {
                    result[i] = 'A';
                }
            }

            return new string(result);
        }
        static string GetInitials(string str)
        {
            string initials = "";
            if (str.Length > 0)
            {
                initials += str[0];
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ' && char.IsLetter(str[i]))
                {
                    initials += str[i];
                }
            }

            return initials.ToUpper();  
        }
        static string OddEvenUppercase(string str)
        {
            char[] result = str.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    if ((i + 1) % 2 != 0)  
                    {
                        result[i] = char.ToUpper(result[i]);
                    }
                    else  
                    {
                        result[i] = char.ToLower(result[i]);
                    }
                }
            }
            return new string(result);

           
        }
    }
}


    

