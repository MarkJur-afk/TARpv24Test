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
                    Console.WriteLine("colour Green");
                    break;

                case "red":
                    Console.WriteLine("colour Red");
                    break;

                case "white":
                    Console.WriteLine("colour White");
                    break;
                
                case "orange":
                    Console.WriteLine("colour Orange");
                    break;

                default:
                    Console.WriteLine("not colour");
                    break;
            }
        }
    }
}
