using System;

namespace RndomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random rnd = new Random();
            int number = rnd.Next(1, 6);
            Console.WriteLine(number);

            switch (number)
            {
                case 1:
                    Console.WriteLine("you got 1");
                    break;

                case 2:
                    Console.WriteLine("you got 2");
                    break;

                case 3:
                    Console.WriteLine("you got 3");
                    break;

                case 4:
                    Console.WriteLine("you got 4");
                    break;

                case 5:
                    Console.WriteLine("you got 5");
                    break;

                case 6:
                    Console.WriteLine("you got 6");
                    break;
            }
         }
    }
}
