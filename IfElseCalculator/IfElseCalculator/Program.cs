using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Insert first number:");
            int firstNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int calculationType = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number:");
            int secondNr = int.Parse(Console.ReadLine());

            float result = 0;

            if (calculationType == 1)
            {
                result = firstNr + secondNr;
                Console.WriteLine(firstNr + " + " + secondNr + " = " + result);
            }
            else if (calculationType == 2)
            {
                result = firstNr - secondNr;
                Console.WriteLine(firstNr + " - " + secondNr + " = " + result);
            }
            else if (calculationType == 3)
            {
                result = firstNr * secondNr;
                Console.WriteLine(firstNr + " * " + secondNr + " = " + result);
            }
            else if (calculationType == 4)
            {
                if (secondNr == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = (float)firstNr / secondNr;
                    Console.WriteLine(firstNr + " / " + secondNr + " = " + result);
                }
            }
            else
            {
                Console.WriteLine("Invalid calculation type.");
            }
        }
    }
}