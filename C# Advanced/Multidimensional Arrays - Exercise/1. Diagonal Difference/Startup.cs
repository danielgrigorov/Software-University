using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Startup
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());

            var matrix = new int[sizes, sizes];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum1 += matrix[i, i];
            }

            int j = matrix.GetLength(1) - 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum2 += matrix[i, j];
                j--;
            }

            int result = Math.Abs(sum1 - sum2);

            Console.WriteLine(result);
        }
    }
}
