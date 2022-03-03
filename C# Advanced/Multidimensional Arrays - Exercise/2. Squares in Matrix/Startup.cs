using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(current[col]);
                }
            }

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row,col] == matrix[row, col+1] && matrix[row+1, col] == matrix[row + 1, col + 1])
                    {
                        if (matrix[row, col] == matrix[row + 1, col] && matrix[row, col + 1] == matrix[row + 1, col + 1])
                        {
                            sum++;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
