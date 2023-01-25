using System;
using System.Reflection;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[1000];

            int i = 0;

            while (true)
            {
                Console.Write("\nSkriv in ett namn här: "); namn[i] = Console.ReadLine().ToLower();

                Console.Write("\nVill du skriva in ett till namn (j/n)?: "); string val = Console.ReadLine().ToLower();

                if (val == "n")
                {
                    break;
                }

                i++;
            }

            Console.Write("\nSkriv in valfritt namn av de namnen du skrev in: "); string nynamn = Console.ReadLine().ToLower();

            int antal = 0;

            for (i = 0; i < namn.Length; i++)
            {
                if (namn[i] == nynamn)
                {
                    antal++;
                }
            }

            Console.Write($"\nDet namnet skrev du in {antal} gånger.");
        }
    }
}
