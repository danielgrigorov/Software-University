using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "swap" && command.Length == 5)
                {
                    if (int.Parse(command[1]) >=0 && int.Parse(command[1]) < sizes[0] && int.Parse(command[3]) >= 0 && int.Parse(command[1]) < sizes[0] && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < sizes[1] && int.Parse(command[4]) >= 0 && int.Parse(command[2]) < sizes[1])
                    {
                        string oldKon = matrix[int.Parse(command[1]), int.Parse(command[2])];
                        string newKon = matrix[int.Parse(command[3]), int.Parse(command[4])];

                        matrix[int.Parse(command[3]), int.Parse(command[4])] = oldKon;
                        matrix[int.Parse(command[1]), int.Parse(command[2])] = newKon;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            }
        }
    }
}
