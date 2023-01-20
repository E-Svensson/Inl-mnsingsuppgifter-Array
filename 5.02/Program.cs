using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nHur många heltal vill du skriva in? Svara här: "); int antal = int.Parse(Console.ReadLine());

            int[] tal = new int[antal];

            Console.WriteLine("\nDu ska nu skriva ut de heltalen.");

            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write($"Skriv tal {i+1}: "); tal[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nHär är talen du skrev in:");
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine($"Tal {i+1}: {tal[i]}");
            }
        }
    }
}
