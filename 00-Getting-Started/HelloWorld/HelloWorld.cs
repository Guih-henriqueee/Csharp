using System;

namespace HelloWorld
{
    class Program
    {
        // Constants are immutable values once declared.
        // If you try to assign a new value to a constant variable, it will result in a compile-time error.
        const string name = "Guilherme";
        const string lastName = "Martins";
        
        // This line is not allowed here, because 'fullName' is not const (depends on concatenation)
        // Move to inside Main method where non-const logic is allowed.

        static void Main(string[] args)
        {
            // Initial output
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the beginning of the study.");
            Console.WriteLine("New language in summary.");
            Console.WriteLine("Let's go!");

            // 🔹 Variables and Types in C#
            int age = 24;                       // Integer type
            char initialName = 'G';             // A single character
            bool isMale = true;                 // Boolean: true
            bool isFemale = false;              // Boolean: false
            double salary = 3500.50;            // Decimal numbers

            string fullName = lastName + " " + name;

            // Displaying variable values
            Console.WriteLine($"\nName: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Initial: {initialName}");
            Console.WriteLine($"Salary: ${salary}");
            Console.WriteLine($"Is Male? {isMale}");
            Console.WriteLine($"Is Female? {isFemale}");

            // 🔹 Type Conversions
            Console.WriteLine("\nConversions:");
            Console.WriteLine(Convert.ToString(salary));    // double to string
            Console.WriteLine(Convert.ToDouble(age));        // int to double
            Console.WriteLine(Convert.ToInt32(salary));      // double to int
            Console.WriteLine(Convert.ToString(isMale));     // bool to string
        }
    }
}
