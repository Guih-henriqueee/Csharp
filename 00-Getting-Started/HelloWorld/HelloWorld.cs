using System;

namespace HelloWorld
{
    class Program
    {
        // Constants are immutable values once declared.
        const string name = "Guilherme";

        static void Main(string[] args)
        {
            // Initial output
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the beginning of the study.");
            Console.WriteLine("New language in summary.");
            Console.WriteLine("Let's go!");

            // 🔹 Variables and Types in C#

            int age = 24;                        // Integers
            char initialName = 'G';              // A single character
            bool isMale = true;                  // Boolean: true
            bool isFemale = false;               // Boolean: false
            double salary = 3500.50;             // Decimal numbers

            // Displaying variable values
            Console.WriteLine($"\nName: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Initial: {initialName}");
            Console.WriteLine($"Salary: ${salary}");
            Console.WriteLine($"Is Male? {isMale}");
            Console.WriteLine($"Is Female? {isFemale}");
        }
    }
}
