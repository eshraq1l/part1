using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task11
{
    internal class task11
    {
        
        static void Main(string[] args)
        {
            // loan eligibility checker
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your monthly income : ");
            double income = double.Parse(Console.ReadLine()!);

            Console.Write("Do you have an existing loan? (yes/no): ");
            string loanAnswer = Console.ReadLine()!;
            bool hasLoan = loanAnswer.ToLower() == "yes";

            bool ageOk = age >= 20 && age <= 50;
            bool incomeOk = income >= 550;

            if (ageOk && incomeOk && !hasLoan)
            {
                Console.WriteLine("Congratulations! You are eligible for the loan.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for the loan.");
                // now figure out why
                if (!ageOk)
                {
                    Console.WriteLine("Reason: age is out of the allowed range (20-50).");
                }
                if (!incomeOk)
                {
                    Console.WriteLine("Reason: monthly income is too low (needs to be at least 550 OMR).");
                }
                if (hasLoan)
                {
                    Console.WriteLine("Reason: you already have an existing loan.");
                }
            }
        }
    }
}
 
    