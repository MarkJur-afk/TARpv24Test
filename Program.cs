namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            double r = 637800000;
            double eur = 25.75;
            double Pmaa = 2 * Math.PI * r;
            double result = Pmaa / eur;
            Console.WriteLine("Ümber maa " + result);
        }
    }
}
