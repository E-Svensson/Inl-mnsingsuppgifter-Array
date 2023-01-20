using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svar = new string[10];

            svar[0] = "Ja";
            svar[1] = "Nej";
            svar[2] = "Självkart";
            svar[3] = "Är du dum eller?";
            svar[4] = "Nej för fan";
            svar[5] = "Det tycker jag";
            svar[6] = "Vet ej";
            svar[7] = "Obesvarlig fråga";
            svar[8] = "ERROR 404";
            svar[9] = "Kommer aldrig fungera";

            Random Slump = new Random();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vad vill du fråga den magiska 8-bollen?");
                Console.Write("\nStäll din fråga här: "); Console.ReadLine();

                int nr = Slump.Next(10);

                Console.WriteLine($"\nDen magiska 8-bollen svarar såhär: {svar[nr]}");

                Console.Write("\nSkriv \"a\" om du vill avsluta programmet, skriv annars vad som helst för att fråga en ny fråga: "); string val = Console.ReadLine();

                if (val == "a")
                {
                    break;
                }
            }
        }
    }
}
