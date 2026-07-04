using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task15
{
    internal class tasak15
    {
 
        static void Main(string[] args)
        {
            Console.Write("Enter program type (S = Science, A = Arts): ");
            char program = Convert.ToChar(Console.ReadLine()!);

            Console.Write("Enter your GPA (out of 4.0): ");
            double gpa = double.Parse(Console.ReadLine()!);

            Console.Write("Enter your entrance exam score (out of 100): ");
            double examScore = double.Parse(Console.ReadLine()!);

            Console.Write("Do you have an extracurricular achievement? (yes/no): ");
            string extraAnswer = Console.ReadLine()!;
            bool hasExtra = extraAnswer.ToLower() == "yes";

            bool meetsRequirement = false;

            switch (program)
            {
                case 'S':
                    meetsRequirement = gpa >= 3.0 && examScore >= 75;

                    if (meetsRequirement)
                    {
                        Console.WriteLine("Result: Admitted");
                    }
                    else if (hasExtra)
                    {
                        Console.WriteLine("Result: Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Result: Not Admitted");
                    }
                    Console.WriteLine("Program: Science");
                    break;

                case 'A':
                    meetsRequirement = gpa >= 2.5 && examScore >= 60;

                    if (meetsRequirement)
                    {
                        Console.WriteLine("Result: Admitted");
                    }
                    else if (hasExtra)
                    {
                        Console.WriteLine("Result: Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Result: Not Admitted");
                    }
                    Console.WriteLine("Program: Arts");
                    break;

                default:
                    Console.WriteLine("Invalid program type");
                    break;
            }
        }
    }
}
 
    