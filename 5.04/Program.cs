using System;
using System.Net.Http.Headers;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[7];

            namn[0] = "Gabriel";
            namn[1] = "Bertil";
            namn[2] = "Gunnert";
            namn[3] = "Lars";
            namn[4] = "Martin";
            namn[5] = "Olof";
            namn[6] = "Anders";

            string först = "Gabriel";

            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i].CompareTo(först) < 0)
                {
                    först = namn[i];
                }
            }

            Console.WriteLine(först);
        }
    }
}
