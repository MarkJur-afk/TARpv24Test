namespace SwitchVocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Kirjuta mis värv sin tahad: green, red, white või orange");
            string värv = Console.ReadLine();
            

            switch (värv)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("colour Green");
                    break;

                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("colour Red");
                    break;

                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("colour White");
                    break;
                
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("colour Magenta");
                    break;

                default:
                    Console.WriteLine("not colour");
                    break;
            }
        }
    }
}
