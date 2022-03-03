using System;
using System.Linq;

namespace _3._Primary_Diagonal
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

            int sum = 0;


            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
