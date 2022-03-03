using System;
using System.Linq;

namespace _02._Re_Volt
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commands = int.Parse(Console.ReadLine());
            var matrix = new char[n,n];
            int currentRow = 0;
            int currentCol = 0;
            bool playerFound = false;
            bool playerWon = false;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = input[col];

                    if (!playerFound)
                    {
                        if (matrix[row,col] == 'f')
                        {
                            currentRow = row;
                            currentCol = col;
                            playerFound = true;
                        }
                    }
                }
            }
            for (int i = 0; i < commands; i++)
            {
                string currentCommand = Console.ReadLine();

                if (currentCommand == "down")
                {
                    if (currentRow +1 < n)
                    {
                        int nextRow = currentRow + 1;
                        int nextCol = currentCol;

                        if (matrix[nextRow,nextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[nextRow, nextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }

                        else if (matrix[nextRow,nextCol] == 'T')
                        {

                        }
                        else if (matrix[nextRow,nextCol] == 'B')
                        {
                            if (nextRow +1 < n)
                            {
                                int newNextRow = currentRow + 2;
                                int newNextCol = currentCol;

                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);


                            }
                            else
                            {
                                int newNextRow = 0;
                                int newNextCol = currentCol;

                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                        }
                        else
                            RegularChange(matrix, ref currentRow, ref currentCol, nextRow, nextCol);
                    }
                    else
                    {
                        int newNextRow = 0;
                        int newNextCol = currentCol;
                        if (matrix[newNextRow, newNextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[newNextRow, newNextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else
                            RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                    }
                }
                else if (currentCommand == "up")
                {
                    if (currentRow - 1 >= 0)
                    {
                        int nextRow = currentRow - 1;
                        int nextCol = currentCol;
                        if (matrix[nextRow, nextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[nextRow, nextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else if (matrix[nextRow, nextCol] == 'T')
                        {

                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            if (nextRow - 1 >= 0)
                            {
                                int newNextRow = currentRow - 2;
                                int newNextCol = currentCol;
                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                            else
                            {
                                int newNextRow = n -1;
                                int newNextCol = currentCol;
                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                        }
                        else
                            RegularChange(matrix, ref currentRow, ref currentCol, nextRow, nextCol);
                    }
                    else
                    {
                        int newNextRow = n-1;
                        int newNextCol = currentCol;
                        if (matrix[newNextRow, newNextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[newNextRow, newNextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else
                            RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                    }
                }
                else if (currentCommand == "right")
                {
                    if (currentCol + 1 < n)
                    {
                        int nextRow = currentRow;
                        int nextCol = currentCol +1;
                        if (matrix[nextRow, nextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[nextRow, nextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else if (matrix[nextRow, nextCol] == 'T')
                        {

                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            if (nextCol + 1 < n)
                            {
                                int newNextRow = currentRow;
                                int newNextCol = currentCol + 2;
                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                            else
                            {
                                int newNextRow = currentRow;
                                int newNextCol = 0;
                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                        }
                        else
                            RegularChange(matrix, ref currentRow, ref currentCol, nextRow, nextCol);
                    }

                    else
                    {
                        int newNextRow = currentRow;
                        int newNextCol = 0;
                        if (matrix[newNextRow, newNextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[newNextRow, newNextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else
                            RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                    }
                }

                else if (currentCommand == "left")
                {
                    if (currentCol - 1 >= 0)
                    {
                        int nextRow = currentRow;
                        int nextCol = currentCol - 1;
                        if (matrix[nextRow, nextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[nextRow, nextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else if (matrix[nextRow, nextCol] == 'T')
                        {

                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            if (nextCol - 1 >= 0)
                            {
                                int newNextRow = currentRow;
                                int newNextCol = currentCol - 2;
                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                            else
                            {
                                int newNextRow = currentRow;
                                int newNextCol = n-1;
                                if (matrix[newNextRow, newNextCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    playerWon = true;
                                    matrix[newNextRow, newNextCol] = 'f';
                                    matrix[currentRow, currentCol] = '-';
                                    break;
                                }
                                else
                                    RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                            }
                        }
                        else
                            RegularChange(matrix, ref currentRow, ref currentCol, nextRow, nextCol);
                    }
                    else
                    {
                        int newNextRow = currentRow;
                        int newNextCol = n -1;
                        if (matrix[newNextRow, newNextCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            playerWon = true;
                            matrix[newNextRow, newNextCol] = 'f';
                            matrix[currentRow, currentCol] = '-';
                            break;
                        }
                        else
                            RegularChangeNew(matrix, ref currentRow, ref currentCol, newNextRow, newNextCol);
                    }
                }
            }
            if (!playerWon)
            {
                Console.WriteLine("Player lost!");
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

        private static void RegularChange(char[,] matrix, ref int currentRow, ref int currentCol, int nextRow, int nextCol)
        {
            matrix[nextRow, nextCol] = 'f';
            matrix[currentRow, currentCol] = '-';
            currentRow = nextRow;
            currentCol = nextCol;
        }

        private static void RegularChangeNew(char[,] matrix, ref int currentRow, ref int currentCol, int newNextRow, int newNextCol)
        {
            matrix[newNextRow, newNextCol] = 'f';
            matrix[currentRow, currentCol] = '-';
            currentRow = newNextRow;
            currentCol = newNextCol;
        }
    }
}
