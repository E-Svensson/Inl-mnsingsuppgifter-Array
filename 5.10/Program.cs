using System;
using System.Reflection;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in flera heltal med mellanslag som mellanrum: "); string input = Console.ReadLine();

            string[] inputArray = input.Trim().Split();
            int[] ArrayAntal = new int[inputArray.Length];
            int flestAntal = 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        ArrayAntal[i]++;
                    }
                }
                Console.WriteLine(ArrayAntal[i]);
            }
        }
    }
}
