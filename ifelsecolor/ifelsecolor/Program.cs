namespace ifelsecolor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose color: red, blue, green, white ");
            string color = Console.ReadLine();
            if (color == "red" || color == "blue" || color == "green" || color == "white")
            {
                Console.WriteLine("your color is " + color);
            }
            else
            {
                Console.WriteLine("you dont have this color!");
            }

        }
    }
}
