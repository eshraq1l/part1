using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task14
{
    internal class task14
    {
         
        static void Main(string[] args)
        {
            Console.Write("Enter product code (1 = Headphones, 2 = Keyboard, 3 = Mouse): ");
            int code = Convert.ToInt32(Console.ReadLine()!);

            double unitPrice = 0;
            string productName = "";

            switch (code)
            {
                case 1:
                    productName = "Headphones";
                    unitPrice = 9.000;
                    break;
                case 2:
                    productName = "Keyboard";
                    unitPrice = 15.000;
                    break;
                case 3:
                    productName = "Mouse";
                    unitPrice = 7.000;
                    break;
                default:
                    Console.WriteLine("Invalid product code");
                    return; // stop here, can't continue without a valid product
            }

            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Do you have a discount coupon? (yes/no): ");
            string couponAnswer = Console.ReadLine()!;
            bool hasCoupon = couponAnswer.ToLower() == "yes";

            double subtotal = unitPrice * qty;
            double discount = 0;

            if (hasCoupon && subtotal > 20)
            {
                discount = subtotal * 0.13;
            }

            double afterDiscount = subtotal - discount;
            double tax = afterDiscount * 0.05;
            double total = afterDiscount + tax;

            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Subtotal: " + subtotal + " OMR");
            Console.WriteLine("Discount: " + discount + " OMR");
            Console.WriteLine("Tax: " + tax + " OMR");
            Console.WriteLine("Final Total: " + total + " OMR");
        }
    }
}
 
    