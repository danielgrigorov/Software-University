using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

            var listOfRows = new List<int>();
            var listfOfCols = new List<int>();

            var matrix = new int[n, m];

            int numberOfFlowers = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bloom Bloom Plow")
                {
                    break;
                }
                else
                {
                    var input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    var currentRow = input[0];
                    var currentCol = input[1];

                    if (currentRow >= 0 && currentRow < n && currentCol >= 0 && currentCol <n)
                    {
                        numberOfFlowers++;
                        listOfRows.Add(currentRow);
                        listfOfCols.Add(currentCol);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates.");
                    }
                }
            }

            for (int i = 0; i < numberOfFlowers; i++)
            {
                for (int j = 0; j < listfOfCols[i]; j++)
                {
                    matrix[listOfRows[i], j] += 1;
                }
                for (int k = listfOfCols[i]; k < n; k++)
                {
                    matrix[listOfRows[i],k] += 1;
                }

                for (int l = 0; l < listOfRows[i]; l++)
                {
                    matrix[l, listfOfCols[i]] += 1;
                }
                for (int o = listOfRows[i]; o < m; o++)
                {
                    matrix[o, listfOfCols[i]] += 1;
                }

                matrix[listOfRows[i], listfOfCols[i]] -= 1;
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
