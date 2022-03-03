using System;

namespace _4._Symbol_in_Matrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());

            var matrix = new char[sizes, sizes];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string current = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            char result = char.Parse(Console.ReadLine());

            bool success = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (result == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        success = true;
                        break;
                    }
                }

                if (success)
                {
                    break;
                }

            }

            if (success == false)
            {
                Console.WriteLine($"{result} does not occur in the matrix ");
            }
        }
    }
}
