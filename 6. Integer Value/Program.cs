using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Integer_Value
{
    internal class Program
    {
        static bool CheckRange(int a, int b, int c)
        {
            return (a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50);
        }

        static void Main(string[] args)
        {
            int[,] testCases = {
            {11, 20, 12},
            {30, 30, 17},
            {25, 35, 50},
            {15, 12, 8}
        };

            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                int a = testCases[i, 0];
                int b = testCases[i, 1];
                int c = testCases[i, 2];

                bool result = CheckRange(a, b, c);
                Console.WriteLine(result);

                Console.ReadLine();
            }    }
    }
}
