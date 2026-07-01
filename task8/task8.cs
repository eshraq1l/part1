using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task8
{
    internal class task8
    {


        static void Main(string[] args)
        {
            {

                //  Task 8
                Console.Write("Enter total bill amount: ");
                double bill = Convert.ToDouble(Console.ReadLine()!);

                Console.Write("Are you a loyalty member? (yes/no): ");
                string memberAnswer = Console.ReadLine()!;
                bool isMember = (memberAnswer == "yes");

                double discountAmount = 0;
                double finalAmount = bill;

                if (bill > 20 && isMember)
                {
                    discountAmount = bill * 0.18;
                    finalAmount = bill - discountAmount;
                }

                Console.WriteLine("Original Bill: " + bill + " OMR");
                Console.WriteLine("Discount Amount: " + discountAmount + " OMR");
                Console.WriteLine("Final Amount to Pay: " + finalAmount + " OMR");

            


            }
        }
    }
}