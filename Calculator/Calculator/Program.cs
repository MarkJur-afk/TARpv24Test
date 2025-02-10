namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("insert first number");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            float calculationType = float.Parse(Console.ReadLine());

            Console.WriteLine("insert second number");
            float secondNr = float.Parse(Console.ReadLine());

            float result = 0;

            switch (calculationType)
            {
                case 1:
                    result = firstNr + secondNr;
                    Console.WriteLine(firstNr + " + " + secondNr + " = " + result);
                    break;

                default:
                    break;
            }
            switch (calculationType)
            {
                case 2:
                    result = firstNr - secondNr;
                    Console.WriteLine(firstNr + " - " + secondNr + " = " + result);
                    break;

                default:
                    break;
                }
            switch (calculationType)
            {
                case 3:
                    result = firstNr * secondNr;
                    Console.WriteLine(firstNr + " * " + secondNr + " = " + result);
                    break;

                default:
                    break;
            }
            switch (calculationType)
            {
                case 4:
                    result = firstNr / secondNr;
                    Console.WriteLine(firstNr + " / " + secondNr + " = " + result);
                    break;

                default:
                    break;
            }
        }        
    }
}
