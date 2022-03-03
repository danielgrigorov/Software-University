using System;
using System.Linq;

namespace _9._Miner__not_included_in_final_score_
{
    class Startup
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            int coalsCount = 0;
            int counter = 0;

            var startRow = 0;
            var startCol = 0;

            bool equalGame = true;

            var commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(current[col]);

                    if (char.Parse(current[col]) == 'c')
                    {
                        coalsCount++;
                    }

                    if (char.Parse(current[col]) == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];

                if (currentCommand == "up" && startRow >=1)
                {
                    startRow = startRow - 1;

                    if (matrix[startRow,startCol] == 'c')
                    {
                        counter++;
                        matrix[startRow, startCol] = '*';

                        if (counter == coalsCount)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            equalGame = false;
                            break;
                        }
                    }

                    if (matrix[startRow,startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        equalGame = false;

                        break;
                    }
                }

                else if (currentCommand == "down" && startRow < size - 1)
                {
                    startRow = startRow + 1;

                    if (matrix[startRow, startCol] == 'c')
                    {
                        counter++;
                        matrix[startRow, startCol] = '*';

                        if (counter == coalsCount)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            equalGame = false;

                            break;
                        }
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        equalGame = false;

                        break;
                    }
                }

                else if (currentCommand == "right" && startCol < size - 1)
                {
                    startCol = startCol + 1;

                    if (matrix[startRow, startCol] == 'c')
                    {
                        counter++;
                        matrix[startRow, startCol] = '*';

                        if (counter == coalsCount)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            equalGame = false;

                            break;
                        }
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        equalGame = false;

                        break;
                    }
                }

                else if (currentCommand == "left" && startCol >= 1)
                {
                    startCol = startCol - 1;

                    if (matrix[startRow, startCol] == 'c')
                    {
                        counter++;
                        matrix[startRow, startCol] = '*';

                        if (counter == coalsCount)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            equalGame = false;

                            break;
                        }
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        equalGame = false;

                        break;
                    }
                }
            }

            if (equalGame)
            {
                Console.WriteLine($"{coalsCount - counter} coals left. ({startRow}, {startCol})");
            }
        }
    }
}
