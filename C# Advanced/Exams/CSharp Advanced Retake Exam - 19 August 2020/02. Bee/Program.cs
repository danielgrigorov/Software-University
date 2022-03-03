using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];
            int beeRow = 0;
            int beeCol = 0;

            bool BeeFound = false;

            int flowersCount = 0;

            for (int row = 0; row < n; row++)
            {
                var current = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = current[col];

                    if (!BeeFound)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            beeRow = row;
                            beeCol = col;
                            BeeFound = true;
                        }
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                else if (command == "up")
                {
                    if (beeRow - 1 >= 0)
                    {
                        matrix[beeRow, beeCol] = '.';

                        int newBeeRow = beeRow - 1;

                        if (matrix[newBeeRow,beeCol] == 'f')
                        {
                            flowersCount++;
                            matrix[newBeeRow, beeCol] = 'B';
                            beeRow = newBeeRow;
                        }
                        else if (matrix[newBeeRow,beeCol] == 'O')
                        {
                            matrix[newBeeRow, beeCol] = '.';

                            if (matrix[newBeeRow - 1, beeCol] == 'f')
                            {
                                flowersCount++;
                                matrix[newBeeRow - 1, beeCol] = 'B';
                                beeRow = newBeeRow - 1;
                            }
                            else
                            {
                                matrix[newBeeRow - 1, beeCol] = 'B';
                                beeRow = newBeeRow - 1;
                            }
                        }
                        else
                        {
                            matrix[newBeeRow, beeCol] = 'B';
                            beeRow = newBeeRow;
                        }

                        
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                else if (command == "down")
                {
                    if (beeRow + 1 < n)
                    {
                        matrix[beeRow, beeCol] = '.';

                        int newBeeRow = beeRow + 1;

                        if (matrix[newBeeRow, beeCol] == 'f')
                        {
                            flowersCount++;
                            matrix[newBeeRow, beeCol] = 'B';
                            beeRow = newBeeRow;
                        }
                        else if (matrix[newBeeRow, beeCol] == 'O')
                        {
                            matrix[newBeeRow, beeCol] = '.';

                            if (matrix[newBeeRow + 1, beeCol] == 'f')
                            {
                                flowersCount++;
                                matrix[newBeeRow + 1, beeCol] = 'B';
                                beeRow = newBeeRow + 1;
                            }
                            else
                            {
                                matrix[newBeeRow + 1, beeCol] = 'B';
                                beeRow = newBeeRow + 1;
                            }
                        }

                        else
                        {
                            matrix[newBeeRow, beeCol] = 'B';
                            beeRow = newBeeRow;
                        }

                        
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                else if (command == "left")
                {
                    if (beeCol - 1 >= 0)
                    {
                        matrix[beeRow, beeCol] = '.';

                        int newBeeCol = beeCol - 1;

                        if (matrix[beeRow, newBeeCol] == 'f')
                        {
                            flowersCount++;
                            matrix[beeRow, newBeeCol] = 'B';
                            beeCol = newBeeCol;
                        }
                        else if (matrix[beeRow, newBeeCol] == 'O')
                        {
                            matrix[beeRow, newBeeCol] = '.';

                            if (matrix[beeRow, newBeeCol - 1] == 'f')
                            {
                                flowersCount++;
                                matrix[beeRow, newBeeCol - 1] = 'B';
                                beeCol = newBeeCol - 1;
                            }
                            else
                            {
                                matrix[beeRow, newBeeCol - 1] = 'B';
                                beeCol = newBeeCol - 1;
                            }
                        }
                        else
                        {
                            matrix[beeRow, newBeeCol] = 'B';
                            beeCol = newBeeCol;
                        }

                        
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                else if (command == "right")
                {
                    if (beeCol + 1 < n)
                    {
                        matrix[beeRow, beeCol] = '.';

                        int newBeeCol = beeCol + 1;

                        if (matrix[beeRow, newBeeCol] == 'f')
                        {
                            flowersCount++;
                            matrix[beeRow, newBeeCol] = 'B';
                            beeCol = newBeeCol;
                        }
                        else if (matrix[beeRow, newBeeCol] == 'O')
                        {
                            matrix[beeRow, newBeeCol] = '.';

                            if (matrix[beeRow, newBeeCol + 1] == 'f')
                            {
                                flowersCount++;
                                matrix[beeRow, newBeeCol + 1] = 'B';
                                beeCol = newBeeCol + 1;
                            }
                            else
                            {
                                matrix[beeRow, newBeeCol + 1] = 'B';
                                beeCol = newBeeCol + 1;
                            }
                        }
                        else
                        {
                            matrix[beeRow, newBeeCol] = 'B';
                            beeCol = newBeeCol;
                        }

                        
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }
            }

            if (flowersCount < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowersCount} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersCount} flowers!");
            }

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
