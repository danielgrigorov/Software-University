using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            int currentSum = 0;
            int maxSum = int.MinValue;

            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        first = matrix[row, col];
                        second = matrix[row, col + 1];
                        third = matrix[row + 1, col];
                        fourth = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{first} {second}");
            Console.WriteLine($"{third} {fourth}");

            Console.WriteLine(maxSum);
        }
    }
}
