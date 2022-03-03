using System;
using System.Linq;

namespace _8._Bombs__not_included_in_final_score_
{
    class Startup
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new long[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            var bombs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < bombs.Length; i++)
            {
                var currentBomb = bombs[i].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int currentRow = int.Parse(currentBomb[0]);
                int currentCol = int.Parse(currentBomb[1]);
                long currentValue = matrix[currentRow, currentCol];

                if (matrix[currentRow, currentCol] > 0)
                {
                    if (matrix[currentRow, currentCol] > 0)
                    {
                        matrix[currentRow, currentCol] -= currentValue;
                    }

                    if (currentRow > 0 && matrix[currentRow - 1, currentCol] > 0)
                    {
                        matrix[currentRow - 1, currentCol] -= currentValue;
                    }
                    if (currentRow < size - 1 && matrix[currentRow + 1, currentCol] > 0)
                    {
                        matrix[currentRow + 1, currentCol] -= currentValue;
                    }

                    if (currentCol > 0 && matrix[currentRow, currentCol - 1] > 0)
                    {
                        matrix[currentRow, currentCol - 1] -= currentValue;
                    }
                    if (currentCol < size - 1 && matrix[currentRow, currentCol + 1] > 0)
                    {
                        matrix[currentRow, currentCol + 1] -= currentValue;
                    }

                    if (currentRow > 0 && currentCol > 0 && matrix[currentRow - 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol - 1] -= currentValue;
                    }

                    if (currentRow < size - 1 && currentCol > 0 && matrix[currentRow + 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol - 1] -= currentValue;
                    }

                    if (currentRow > 0 && currentCol < size - 1 && matrix[currentRow - 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol + 1] -= currentValue;
                    }

                    if (currentRow < size - 1 && currentCol < size - 1 && matrix[currentRow + 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol + 1] -= currentValue;
                    }
                }
            }

            long sum = 0;
            long count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
