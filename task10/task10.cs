using System;
using System.Collections.Generic;
using System.Text;

namespace part1.task10
{
    internal class task10
    { 



        static void Main(string[] args)
        {
            //  Task 10 
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Enter operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine()!);

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (num1* num2));
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
break;
                case '%':
    if (num2 == 0)
    {
        Console.WriteLine("Cannot divide by 0");
    }
    else
    {
        Console.WriteLine("Result: " + (num1 % num2));
    }
    break;
default:
    Console.WriteLine("Invalid operator");
    break;



}
        }
    }
}

        

    
