using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task9
{
    internal class task9
    {



        static void Main(string[] args)
        {
            {
                //  Task 9 
                Console.Write("Enter day number (1-7): ");
                int dayNumber = Convert.ToInt32(Console.ReadLine()!);

                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day number");
                        break;
                }
            }
        }
    }
}