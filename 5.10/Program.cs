using System;
using System.Reflection;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in flera heltal men mellanslag som mellanrum: "); string input = Console.ReadLine();

            string[] inputArray = input.Split(" ");
            int[] ArrayInteger = new int[inputArray.Length];

            Array.Sort(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i].Contains(inputArray[j]))
                    {
                        ArrayInteger[i]++;
                    }
                }
            }

            Console.Write("\nFöljande tal är vanligast: ");

            for (int i = 0; i < ArrayInteger.Length; i++)
            {
                if (ArrayInteger[i] != 1)
                {
                    Console.Write(inputArray[i]);
                }
            }
        }
    }
}
