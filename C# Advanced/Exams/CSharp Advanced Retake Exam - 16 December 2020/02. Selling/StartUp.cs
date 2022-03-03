using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Selling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int moneyCollected = 0;

            var matrix = new char[n, n];

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < n; row++)
            {
                var current = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = current[col];

                    if (matrix[row,col] == 'S')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (currentRow -1 >=0)
                    {
                        int nextRow = currentRow - 1;
                        int nextCol = currentCol;

                        matrix[currentRow, currentCol] = '-';

                        if (matrix[nextRow,nextCol] >= 48 && matrix[nextRow,nextCol] <= 57)
                        {
                            moneyCollected += int.Parse(matrix[nextRow, nextCol].ToString());
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }

                        else if (matrix[nextRow,nextCol] == 'O')
                        {
                            matrix[nextRow, nextCol] = '-';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row,col] == 'O')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = 'S';
                                    }
                                }
                            }
                        }

                        else
                        {
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[currentRow, currentCol] = '-';

                        break;
                    }
                }

                else if (command == "down")
                {
                    if (currentRow + 1 < n)
                    {
                        int nextRow = currentRow + 1;
                        int nextCol = currentCol;

                        matrix[currentRow, currentCol] = '-';

                        if (matrix[nextRow, nextCol] >= 48 && matrix[nextRow, nextCol] <= 57)
                        {
                            moneyCollected += int.Parse(matrix[nextRow, nextCol].ToString());
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }

                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[nextRow, nextCol] = '-';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'O')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = 'S';
                                    }
                                }
                            }
                        }

                        else
                        {
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[currentRow, currentCol] = '-';

                        break;
                    }
                }

                else if (command == "left")
                {
                    if (currentCol - 1 >= 0)
                    {
                        int nextRow = currentRow;
                        int nextCol = currentCol -1;

                        matrix[currentRow, currentCol] = '-';

                        if (matrix[nextRow, nextCol] >= 48 && matrix[nextRow, nextCol] <= 57)
                        {
                            moneyCollected += int.Parse(matrix[nextRow, nextCol].ToString());
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }

                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[nextRow, nextCol] = '-';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'O')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = 'S';
                                    }
                                }
                            }
                        }

                        else
                        {
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[currentRow, currentCol] = '-';

                        break;
                    }
                }

                else if (command == "right")
                {
                    if (currentCol + 1 < n)
                    {
                        int nextRow = currentRow;
                        int nextCol = currentCol + 1;

                        matrix[currentRow, currentCol] = '-';

                        if (matrix[nextRow, nextCol] >= 48 && matrix[nextRow, nextCol] <= 57)
                        {
                            moneyCollected += int.Parse(matrix[nextRow, nextCol].ToString());
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }

                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[nextRow, nextCol] = '-';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'O')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = 'S';
                                    }
                                }
                            }
                        }

                        else
                        {
                            matrix[nextRow, nextCol] = 'S';
                            currentRow = nextRow;
                            currentCol = nextCol;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[currentRow, currentCol] = '-';

                        break;
                    }
                }

                if (moneyCollected >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }
            }

            Console.WriteLine($"Money: {moneyCollected}");

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
