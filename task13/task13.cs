using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task13
{
    internal class task13
    {
        
    class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter side 1: ");
                double a = double.Parse(Console.ReadLine()!);

                Console.Write("Enter side 2: ");
                double b = double.Parse(Console.ReadLine()!);

                Console.Write("Enter side 3: ");
                double c = double.Parse(Console.ReadLine()!);

                // triangle inequality - all three combos need to hold
                bool isValid = (a + b > c) && (a + c > b) && (b + c > a);

                if (!isValid)
                {
                    Console.WriteLine("These sides do not form a valid triangle.");
                }
                else
                {
                    Console.WriteLine("Valid triangle!");

                    if (a == b && b == c)
                    {
                        Console.WriteLine("Type: Equilateral");
                    }
                    else if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Type: Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Type: Scalene");
                    }
                }
            }
        }
    }
}

