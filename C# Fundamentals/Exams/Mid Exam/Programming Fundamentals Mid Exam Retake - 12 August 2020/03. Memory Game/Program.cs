using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int moves = 0;

            bool lose = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split();

                int firstNumber = int.Parse(token[0]);
                int secondNumber = int.Parse(token[1]);

                moves++;

                if (firstNumber == secondNumber || firstNumber < 0 || secondNumber < 0 || firstNumber > list.Count-1 || secondNumber > list.Count-1)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    list.Insert((list.Count / 2), $"-{moves}a");
                    list.Insert((list.Count / 2), $"-{moves}a");
                }

                else if (list[firstNumber] == list[secondNumber])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[firstNumber]}!");

                    string kon = list[firstNumber];
                    list.Remove(kon);
                    list.Remove(kon);

                }
                else if (list[firstNumber] != list[secondNumber])
                {
                    Console.WriteLine("Try again!");
                }

                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    lose = false;
                    break;
                }
            }

            if (lose)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
            
        }
    }
}
