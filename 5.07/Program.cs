using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] länderStr = { "Kina", "Indien", "USA", "Indonesien", "Pakistan"};
            int[] länderInt = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < länderStr.Length; i++)
            {
                Console.WriteLine($"{länderInt[i]}: {länderStr[i]}");
            }

            Console.Write("\nVälj de länder som ska skrivas ut igen genom att skriva deras nummer på en rad: "); char[] valStr = Console.ReadLine().ToCharArray();

            Console.WriteLine();

            int[] valInt = Array.ConvertAll(valStr, x => (int)Char.GetNumericValue(x));

            for (int i = 0; i < länderStr.Length; i++)
            {
                for (int j = 0; j < valStr.Length; j++)
                {
                    if (länderInt[i] == valInt[j])
                    {
                        Console.WriteLine($"{länderInt[i]}: {länderStr[i]}");
                        break;
                    }
                }
            }
        }
    }
}
