namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            //Task 1 - Personal Info Card
            string name = "ESHRAQ";
            int age = 22;
            double height = 1.90;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + isStudent);

           


            //  Task 2 - Rectangle Calculator 
            Console.Write("Enter rectangle length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            

            
             //task3 
            Console.Write("Enter a whole number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }
            

            ///////////////
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
            
            ///// task 5 
            ///Console.Write("Enter your grade (A, B, C, D, F): ");
            char grade = Convert.ToChar(Console.ReadLine()!);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
                    */
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



            // Task 7
            Console.Write("Enter your age: ");
            int movieAge = Convert.ToInt32(Console.ReadLine());

            string category;
            double price;

            if (movieAge >= 0 && movieAge <= 12)
            {
                category = "Child";
                price = 2.000;
            }
            else if (movieAge >= 13 && movieAge <= 59)
            {
                category = "Adult";
                price = 5.000;
            }
            else
            {
                category = "Senior";
                price = 3.000;
            }

            Console.WriteLine("Category: " + category);
            Console.WriteLine("Ticket Price: " + price + " OMR");



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
                discountAmount = bill * 0.15;
                finalAmount = bill - discountAmount;
            }

            Console.WriteLine("Original Bill: " + bill + " OMR");
            Console.WriteLine("Discount Amount: " + discountAmount + " OMR");
            Console.WriteLine("Final Amount to Pay: " + finalAmount + " OMR");

            Console.WriteLine();

            //  Task 9 
            Console.Write("Enter day number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

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

            //  Task 10 
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

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
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
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

        