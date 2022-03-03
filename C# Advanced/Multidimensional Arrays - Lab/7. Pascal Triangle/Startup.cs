using System;
using System.Linq;
using System.Numerics;

namespace _7._Pascal_Triangle
{
    class Startup
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var jagged = new long[size][];

            if (size > 0)
            {
                jagged[0] = new long[1] { 1 };
            }

            if (size > 1)
            {
                jagged[1] = new long[2] { 1, 1 };
            }


            for (int row = 2; row < size; row++)
            {
                jagged[row] = new long[row + 1];
                jagged[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    jagged[row][col] = jagged[row - 1][col] + jagged[row - 1][col - 1];
                }

                jagged[row][row] = 1;
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
