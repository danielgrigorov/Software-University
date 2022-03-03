using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }
            int currentSum = 0;
            int startIndexRow = 0;
            int startIndexCol = 0;
            int maxSum = int.MinValue;

            if (sizes[0]>=3 && sizes[1]>=3)
            {
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        currentSum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            startIndexRow = row;
                            startIndexCol = col;
                            currentSum = 0;
                        }
                        else
                        {
                            currentSum = 0;
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[startIndexRow, startIndexCol]} {matrix[startIndexRow, startIndexCol + 1]} {matrix[startIndexRow, startIndexCol + 2]}");
            Console.WriteLine($"{matrix[startIndexRow + 1, startIndexCol]} {matrix[startIndexRow + 1, startIndexCol + 1]} {matrix[startIndexRow + 1, startIndexCol + 2]}");
            Console.WriteLine($"{matrix[startIndexRow + 2, startIndexCol]} {matrix[startIndexRow + 2, startIndexCol + 1]} {matrix[startIndexRow + 2, startIndexCol + 2]}");
        }
    }
}
