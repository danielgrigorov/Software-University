using System;
using System.Linq;
using System.Numerics;

namespace _6._Jagged_Array_Manipulator
{
    class Startup
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var jagged = new double[size][];

            for (int row = 0; row < size; row++)
            {
                var current = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                jagged[row] = current;
            }

            for (int row = 0; row < size-1; row++)
            {
                if (jagged[row].Length == jagged[row+1].Length)
                {
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j] *= 2;
                        }
                    }
                }
                else
                {
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j] /= 2;
                        }
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                else if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >-1 && row <size && col >-1 && col <jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }

                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row > -1 && row < size && col > -1 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
