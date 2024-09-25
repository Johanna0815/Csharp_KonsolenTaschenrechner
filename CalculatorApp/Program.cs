using System;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");
            while (true)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operation (+, -, *, /, %): ");
                string op = Console.ReadLine();
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Result: {Calculate(num1, num2, op)}");
                Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") break;
            }
        }

        public static double Calculate(double num1, double num2, string operation)
        {
            return operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero"),
                "%" => num1 * (num2 / 100),
                _ => throw new InvalidOperationException("Invalid operation")
            };
        }
    }
}
