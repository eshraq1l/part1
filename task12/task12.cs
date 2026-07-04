using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task12
{
    internal class task12
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter region code (A = local, B = national, C = international): ");
            char region = Convert.ToChar(Console.ReadLine()!);

            Console.Write("Enter package weight in kg: ");
            double weight = double.Parse(Console.ReadLine()!);

            double baseCost = 0;
            double extra = 0;

            switch (region)
            {
                case 'A':
                    baseCost = 1.000;
                    if (weight > 10)
                        extra = 5.000;
                    else if (weight > 5)
                        extra = 2.000;
                    else
                        extra = 0;

                    Console.WriteLine("Base cost: " + baseCost + " OMR");
                    Console.WriteLine("Extra charge: " + extra + " OMR");
                    Console.WriteLine("Total shipping cost: " + (baseCost + extra) + " OMR");
                    break;

                case 'B':
                    baseCost = 3.000;
                    if (weight > 10)
                        extra = 5.000;
                    else if (weight > 5)
                        extra = 2.000;
                    else
                        extra = 0;

                    Console.WriteLine("Base cost: " + baseCost + " OMR");
                    Console.WriteLine("Extra charge: " + extra + " OMR");
                    Console.WriteLine("Total shipping cost: " + (baseCost + extra) + " OMR");
                    break;

                case 'C':
                    baseCost = 7.000;
                    if (weight > 10)
                        extra = 5.000;
                    else if (weight > 5)
                        extra = 2.000;
                    else
                        extra = 0;

                    Console.WriteLine("Base cost: " + baseCost + " OMR");
                    Console.WriteLine("Extra charge: " + extra + " OMR");
                    Console.WriteLine("Total shipping cost: " + (baseCost + extra) + " OMR");
                    break;

                default:
                    Console.WriteLine("Invalid region");
                    break;
            }
        }
    }
}
 
    