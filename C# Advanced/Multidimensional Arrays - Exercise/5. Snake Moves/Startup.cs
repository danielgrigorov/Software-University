using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new char[sizes[0], sizes[1]];

            string snake = Console.ReadLine();
            int row = 0;
            int col = 0;
            int counter = 0;

            for (int i = 0; i < snake.Length; i++)
            {
                matrix[row, col] = snake[i];
                counter++;

                if (col < matrix.GetLength(1) - 1)
                {
                    col++;
                }
                else
                {
                    row++;
                    col = 0;
                }

                if (counter == sizes[0] * sizes[1])
                {
                    break;
                }

                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (j %2 == 0)
                    {
                        Console.Write($"{matrix[j, k]}");
                    }
                    else
                    {
                        Console.Write($"{matrix[j, matrix.GetLength(1) - k - 1]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
