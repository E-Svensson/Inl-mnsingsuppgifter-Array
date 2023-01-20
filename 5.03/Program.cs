using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];

            frågor[0] = "Hur många planeter finns det i vårat solsystem?";
            frågor[1] = "Vad blir 75 + 24 / 6?";
            frågor[2] = "Hur många typer av ägg-läggande däggdjur finns det?";
            frågor[3] = "Vad heter USA:s president?";

            svar[0] = "8";
            svar[1] = "79";
            svar[2] = "5";
            svar[3] = "joe biden";

            Console.Write("Välj en fråga från 1-4: "); int val = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{frågor[val - 1]}");

            Console.Write("\nSvara här: "); string Svar = Console.ReadLine();

            if (Svar == svar[val - 1])
            {
                Console.WriteLine("\nDet är rätt!");
            }
            else
            {
                Console.WriteLine("\nDet är fel!");
            }
        }
    }
}
