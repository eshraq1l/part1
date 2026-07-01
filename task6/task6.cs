using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task6
{
    internal class task6
    {
        

        static void Main(string[] args)
        {


            // Task 6 
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            string weatherStatus;
            if (celsius < 10)
            {
                weatherStatus = "Cold";
            }
            else if (celsius <= 30)
            {
                weatherStatus = "Mild";
            }
            else
            {
                weatherStatus = "Hot";
            }

            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.WriteLine("Weather: " + weatherStatus);

        }
    } }
