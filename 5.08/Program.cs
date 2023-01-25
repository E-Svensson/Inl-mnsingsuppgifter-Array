using System;
using System.Reflection;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 54, 34, 6231, 25, 288 };
            
            for (int i = 0; i < tal.Length; i++)
            {
                Thread.Sleep(1000);

                char[] c = tal[i].ToString().ToCharArray();

                for (int k = 0; k < c.Length; k++)
                {
                    Thread.Sleep(100);
                    Console.Write(c[k]);
                }

                Console.Write(" ");
            }
        }
    }
}
