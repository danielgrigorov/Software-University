using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                string firstWord = string.Empty;
                string secondWord = string.Empty;

                if (token.Length > 1)
                {
                     firstWord = token[1];
                }
                if (token.Length > 2)
                {
                     secondWord = token[2];
                }

                if (action == "Delete")
                {
                    if (int.Parse(firstWord) +1 <= list.Count-1 && int.Parse(firstWord) +1 >= 0)
                    {
                        list.RemoveAt(int.Parse(firstWord) + 1);
                    }
                }
                else if (action == "Swap")
                {
                    if (list.Contains(firstWord) && list.Contains(secondWord))
                    {
                        int firstWordIndex = list.IndexOf(firstWord);
                        int secondWordIndex = list.IndexOf(secondWord);

                        list[firstWordIndex] = secondWord;
                        list[secondWordIndex] = firstWord;

                    }
                }
                else if (action == "Put")
                {
                    if (int.Parse(secondWord) -1 <= list.Count && int.Parse(secondWord) -1 >= 0)
                    {
                        list.Insert(int.Parse(secondWord) -1, firstWord);
                    }
                }
                else if (action == "Sort")
                {
                    list.Sort();
                    list.Reverse();
                }
                else if (action == "Replace")
                {
                    if (list.Contains(secondWord))
                    {
                        int secondWordIndex = list.IndexOf(secondWord);
                        list.Insert(secondWordIndex, firstWord);
                        list.RemoveAt(secondWordIndex + 1);
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
