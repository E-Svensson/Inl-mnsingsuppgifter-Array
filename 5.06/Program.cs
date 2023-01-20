using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in hur många tal du vill seperarade med en astrisk (\"*\"): "); string input = Console.ReadLine();

            string[] talStr = input.Split("*");

            int[] talInt = Array.ConvertAll(talStr, int.Parse);

            long produkt = 1;

            for (int i = 0; i < talInt.Length; i++)
            {
                produkt *= talInt[i];
            }

            Console.WriteLine($"\nProdukten av dina tal blir {produkt}");
        }
    }
}
