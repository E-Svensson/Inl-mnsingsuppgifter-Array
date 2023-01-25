using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = new string[4];

            meningar[0] = "Detta är en mening.";
            meningar[1] = "Visste du att du näbbdjur inte har några magar?";
            meningar[2] = "Jesus föddes faktiskt för runt 2023 år sedan.";
            meningar[3] = "Krokodilen är grön.";

            for (int i = 0; i < meningar.Length; i++)
            {
                Console.WriteLine(meningar[i] + "\n");
            }
        }
    }
}
