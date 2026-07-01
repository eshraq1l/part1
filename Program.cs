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

            Console.WriteLine();

*/
            //  Task 2 - Rectangle Calculator 
            Console.Write("Enter rectangle length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            Console.WriteLine();

        }
    }
}
