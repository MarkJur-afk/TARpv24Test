using System.ComponentModel;

namespace ifelsejalanumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 44;
            //kontroll kas arv on suurem 189-st

            {
                //kui vastab if tingimustele, siis n intab konsoolis seda arvu
                Console.WriteLine("Its too small");

                //if ja else nestimine
                if (number >= 30 && number <= 33)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you have: " + number);

                }
                else if (number >= 34 && number <= 38)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("you have: " + number);
                
                }
                else if (number >= 39 && number <= 44)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("you have: " + number);

                }
                else if (number >= 45 && number <= 48)
                {
                    Console.WriteLine("you have: " + number);
                    Console.Beep();
                }
                else
                {
                    Console.WriteLine("you have to small leg");
                }
            }
        }
    }
}
