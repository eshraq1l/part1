using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace part1.task2
{
    internal class task2
    {
        static void Main(string[] args)
        {

            ///Task 2 - Rectangle Calculator

            Console.Write("Enter rectangle length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

        }
    }
}

