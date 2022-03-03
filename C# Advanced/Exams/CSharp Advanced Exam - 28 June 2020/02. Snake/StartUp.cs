using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Snake
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            var snakeRow = 0;
            var snakeCol = 0;

            bool foundSnake = false;

            int foodCounter = 0;

            for (int row = 0; row < n; row++)
            {
                var current = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = current[col];

                    if (foundSnake == false)
                    {
                        if (matrix[row, col] == 'S')
                        {
                            snakeRow = row;
                            snakeCol = col;
                            foundSnake = true;
                        }
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (snakeRow -1 >= 0)
                    {
                        var nextRow = snakeRow - 1;
                        var nextCol = snakeCol;

                        if (matrix[nextRow,nextCol] == '*')
                        {
                            foodCounter++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }

                        else if (matrix[nextRow,nextCol] == 'B')
                        {
                            matrix[nextRow, nextCol] = '.';
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }
                }

                else if (command == "down")
                {
                    if (snakeRow + 1 < n)
                    {
                        var nextRow = snakeRow + 1;
                        var nextCol = snakeCol;

                        if (matrix[nextRow, nextCol] == '*')
                        {
                            foodCounter++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }

                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            matrix[nextRow, nextCol] = '.';
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[snakeRow, snakeCol] = '.';

                        break;
                    }
                }

                else if (command == "left")
                {
                    if (snakeCol - 1 >= 0)
                    {
                        var nextRow = snakeRow;
                        var nextCol = snakeCol - 1;

                        if (matrix[nextRow, nextCol] == '*')
                        {
                            foodCounter++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }

                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            matrix[nextRow, nextCol] = '.';
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[snakeRow, snakeCol] = '.';

                        break;
                    }
                }

                else if (command == "right")
                {
                    if (snakeCol + 1 < n)
                    {
                        var nextRow = snakeRow;
                        var nextCol = snakeCol + 1;

                        if (matrix[nextRow, nextCol] == '*')
                        {
                            foodCounter++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }

                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            matrix[nextRow, nextCol] = '.';
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[nextRow, nextCol] = 'S';
                            snakeRow = nextRow;
                            snakeCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[snakeRow, snakeCol] = '.';

                        break;
                    }
                }

                if (foodCounter == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
            }

            Console.WriteLine($"Food eaten: {foodCounter}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
