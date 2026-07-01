using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task4
{
    internal class task4
    {

        static void Main(string[] args)
        {
            //task4 
            Console.Write("Enter your age: ");
            int voterAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have a valid national ID? (yes/no): ");
            string idAnswer = Console.ReadLine()!;
            bool hasValidId = (idAnswer == "yes");

            if (voterAge >= 18 && hasValidId)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are NOT eligible to vote.");
            }
        }
    }
}
        
    
