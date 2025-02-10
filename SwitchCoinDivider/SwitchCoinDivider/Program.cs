namespace SwitchCoinDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

                Console.Write("Enter sum and press enter: ");

            if (int.TryParse(Console.ReadLine(), out int sum) && sum > 0)
            {
                int centAmount = 0;

                if (sum >= 50)
                {
                    centAmount = sum / 50;
                    sum %= 50;
                    Console.WriteLine("50 cents: " + centAmount);
                }

                if (sum >= 20)
                {
                    centAmount = sum / 20;
                    sum %= 20;
                    Console.WriteLine("20 cents: " + centAmount);
                }

                if (sum >= 10)
                {
                    centAmount = sum / 10;
                    sum %= 10;
                    Console.WriteLine("10 cents: " + centAmount);
                }

                if (sum >= 5)
                {
                    centAmount = sum / 5;
                    sum %= 5;
                    Console.WriteLine("5 cents: " + centAmount);
                }

                if (sum >= 2)
                {
                    centAmount = sum / 2;
                    sum %= 2;
                    Console.WriteLine("2 cents: " + centAmount);
                }

                if (sum >= 1)
                {
                    centAmount = sum / 1;
                    Console.WriteLine("1 cent: " + centAmount);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");

            }
        }
            
    }
      
}
