using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task7
{
    internal class task7
    {


        static void Main(string[] args)
        {
            {
                // Task 7
                Console.Write("Enter your age: ");
                int movieAge = Convert.ToInt32(Console.ReadLine());

                string category;
                double price;

                if (movieAge >= 0 && movieAge <= 12)
                {
                    category = "Child";
                    price = 3.000;
                }
                else if (movieAge >= 13 && movieAge <= 59)
                {
                    category = "Adult";
                    price = 7.000;
                }
                else
                {
                    category = "Senior";
                    price = 5.000;
                }

                Console.WriteLine("Category: " + category);
                Console.WriteLine("Ticket Price: " + price + " OMR");


            }
        }
    }
}