namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            //from math import *
            //r=(6378*100000) #maa diametr
            //euro=2.5 #2 euro cm
            //Pmaa=2*pi*r #maa umbermoot
            //vastus=Pmaa/euro
            //print(f"Maa katmiseks kahe euromündiga on vaja {int(vastus):,d} münte")
            //print(f"Maa katmiseks kahe euromündiga on vaja {int(vastus*2):,d} euro")
        

            double r = 637800000;
            double eur = 25.75;
            double Pmaa = 2 * Math.PI * r;
            double result = Pmaa / eur;
            Console.WriteLine("Ümber maa" + result);
        }
    }
}
