using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task5
{
    internal class task5
    {

        static void Main(string[] args)
        {

            ///// task 5 
            ///Console.Write("Enter your grade (A, B, C, D, F): ");
            char grade = Convert.ToChar(Console.ReadLine()!);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}