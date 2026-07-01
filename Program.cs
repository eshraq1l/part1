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
            */

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
        }
    }
}
