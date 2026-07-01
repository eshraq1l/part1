using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task3
{
    internal class task3
    {
        static void Main(string[] args)
        {
            //task3 
            Console.Write("Enter a whole number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }
        }
    }
}