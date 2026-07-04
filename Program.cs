using part1;

namespace Program
{
    class part1
    {
        static void Main(string[] args)
        {


            // ================= Task 1 - Personal Info Card =================
            string name = "eshraq";
                int age = 22;
                double height = 1.65;
                bool isStudent = true;

                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Height: " + height);
                Console.WriteLine("Student: " + isStudent);

                Console.WriteLine();

                // ================= Task 2 - Rectangle Calculator =================
                Console.Write("Enter rectangle length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter rectangle width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * (length + width);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine();

                // ================= Task 3 - Even or Odd Checker =================
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

                Console.WriteLine();

                // ================= Task 4 - Voting Eligibility =================
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

                Console.WriteLine();

                // ================= Task 5 - Grade Letter Lookup =================
                Console.Write("Enter your grade (A, B, C, D, F): ");
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
                        
                }
            }
        }
    }


