using System;

namespace DataTypes
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            // 🔹 Asking for user input
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine()!;

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine()!;

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Are you employed? (true/false):");
            bool isEmployed = Convert.ToBoolean(Console.ReadLine());

            // 🔹 Processing
            string fullName = $"{firstName} {lastName}";

            // 🔹 Outputting results
            Console.WriteLine("\n--- User Summary ---");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: ${salary:F2}");
            Console.WriteLine($"Employed: {isEmployed}");

            // 🔹 Type conversions
            Console.WriteLine("\n--- Conversions ---");
            Console.WriteLine("Age as double: " + Convert.ToDouble(age));
            Console.WriteLine("Salary as string: " + Convert.ToString(salary));
            Console.WriteLine("Employment status as string: " + isEmployed.ToString());
        }
    }
}
