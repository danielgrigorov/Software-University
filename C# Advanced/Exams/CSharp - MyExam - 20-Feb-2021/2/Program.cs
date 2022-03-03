using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            bool gameOver = false;

            int firstPlayerShipsCount = 0;
            int secondPlayerShipsCount = 0;

            var commands = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int row = 0; row < n; row++)
            {
                var current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = current[col];

                    if (matrix[row,col] == '<')
                    {
                        firstPlayerShipsCount++;
                    }

                    if (matrix[row,col] == '>')
                    {
                        secondPlayerShipsCount++;
                    }
                }
            }

            int firstPlayerStartedShips = firstPlayerShipsCount;
            int secondPlayerStartedShips = secondPlayerShipsCount;

            for (int i = 0; i < commands.Length; i++)
            {
                var currentCommand = commands[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentRow = currentCommand[0];
                int currentCol = currentCommand[1];

                if (currentRow < 0 || currentCol < 0 || currentRow >=n || currentCol >= n)
                {
                    continue;
                }

                if (matrix[currentRow, currentCol] == '#')
                {
                    if (currentRow - 1 >= 0)
                    {
                        if (matrix[currentRow - 1, currentCol] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow - 1, currentCol] == '>')
                        {
                            secondPlayerShipsCount--;
                        }

                        matrix[currentRow - 1, currentCol] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentRow + 1 < n)
                    {
                        if (matrix[currentRow + 1, currentCol] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow + 1, currentCol] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow + 1, currentCol] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentCol -1 >= 0)
                    {
                        if (matrix[currentRow, currentCol -1] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow, currentCol -1] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow, currentCol - 1] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentCol + 1 < n)
                    {
                        if (matrix[currentRow, currentCol + 1] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow, currentCol + 1] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow, currentCol + 1] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentCol -1 >= 0 && currentRow -1 >=0)
                    {
                        if (matrix[currentRow-1, currentCol - 1] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow-1, currentCol - 1] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow - 1, currentCol - 1] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentRow +1 <n && currentCol +1 <n)
                    {
                        if (matrix[currentRow+1, currentCol+1] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow+1, currentCol+1] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow + 1, currentCol + 1] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentRow +1 < n && currentCol - 1 >= 0)
                    {
                        if (matrix[currentRow+1, currentCol - 1] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow+1, currentCol - 1] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow + 1, currentCol - 1] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (currentRow -1 >= 0 && currentCol +1 <n)
                    {
                        if (matrix[currentRow-1, currentCol + 1] == '<')
                        {
                            firstPlayerShipsCount--;
                        }
                        else if (matrix[currentRow-1, currentCol + 1] == '>')
                        {
                            secondPlayerShipsCount--;
                        }
                        matrix[currentRow - 1, currentCol + 1] = 'X';

                        if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                        {
                            gameOver = true;
                            break;
                        }
                    }

                    matrix[currentRow, currentCol] = 'X';

                }

                else if (matrix[currentRow,currentCol] == '>')
                {
                    secondPlayerShipsCount--;
                    matrix[currentRow, currentCol] = 'X';

                    if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                    {
                        gameOver = true;
                        break;
                    }
                }

                else if (matrix[currentRow,currentCol] == '<')
                {
                    firstPlayerShipsCount--;
                    matrix[currentRow, currentCol] = 'X';

                    if (firstPlayerShipsCount == 0 || secondPlayerShipsCount == 0)
                    {
                        gameOver = true;
                        break;
                    }
                }

            }

            int destroyedShips = (firstPlayerStartedShips - firstPlayerShipsCount) + (secondPlayerStartedShips - secondPlayerShipsCount);

            if (gameOver)
            {
                if (firstPlayerShipsCount == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                }
                else if (secondPlayerShipsCount == 0)
                {
                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShipsCount} ships left. Player Two has {secondPlayerShipsCount} ships left.");
            }
        }
    }
}
