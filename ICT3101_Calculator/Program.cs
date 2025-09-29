using ICT3101_Calculator;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Calculator _calculator = new Calculator();

        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            double result = 0;

            // 1) Pick the operator first
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add (uses two numbers)");
            Console.WriteLine("\ts - Subtract (uses two numbers)");
            Console.WriteLine("\tm - Multiply (uses two numbers)");
            Console.WriteLine("\td - Divide (uses two numbers; throws if either is 0)");
            Console.WriteLine("\tf - Factorial of first number only");
            Console.WriteLine("\tt - Triangle Area = 0.5 * height * base (two numbers: height, base)");
            Console.WriteLine("\tc - Circle Area = π * r^2 (uses first number as radius)");
            Console.Write("Your option? ");
            string op = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

            // 2) Ask only for the inputs needed
            double cleanNum1 = 0;
            double cleanNum2 = 0;

            try
            {
                switch (op)
                {
                    case "a":
                    case "s":
                    case "m":
                    case "d":
                    case "t":
                        cleanNum1 = ReadDouble("Type first number, then press Enter: ");
                        cleanNum2 = ReadDouble("Type second number, then press Enter: ");
                        break;

                    case "f":
                    case "c":
                        cleanNum1 = ReadDouble("Type the number (n for factorial / radius for circle), then press Enter: ");
                        break;

                    default:
                        Console.WriteLine("Unknown option. Please choose a valid operator.\n");
                        goto ContinueLoop;
                }

                // 3) Do the operation
                result = _calculator.DoOperation(cleanNum1, cleanNum2, op);

                // 4) Show result
                Console.WriteLine(double.IsNaN(result)
                    ? "This operation will result in a mathematical error.\n"
                    : $"Your result: {result:0.##}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying math.\n - Details: " + e.Message + "\n");
            }

        ContinueLoop:
            Console.WriteLine("------------------------\n");
            Console.Write("Press 'q' and Enter to quit the app, or press any other key and Enter to continue: ");
            if ((Console.ReadLine() ?? "") == "q") endApp = true;
            Console.WriteLine();
        }
    }

    // Helper to read & validate a double
    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        double value;
        while (!double.TryParse(input, out value))
        {
            Console.Write("This is not valid input. Please enter a numeric value: ");
            input = Console.ReadLine();
        }
        return value;
    }
}