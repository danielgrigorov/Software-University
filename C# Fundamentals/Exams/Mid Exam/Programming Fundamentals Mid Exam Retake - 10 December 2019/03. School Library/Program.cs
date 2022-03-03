using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                string[] token = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                string action = token[0];
                string firstCommand = token[1];
                string secondCommand = string.Empty;

                if (token.Length == 3)
                {
                     secondCommand = token[2];
                }

                if (action == "Add Book")
                {
                    if (list.Contains(firstCommand))
                    {

                    }
                    else
                    {
                        list.Insert(0, firstCommand);
                    }
                }
                else if (action == "Take Book")
                {
                    if (list.Contains(firstCommand))
                    {
                        list.RemoveAll(x => x == firstCommand);
                    }
                }
                else if (action == "Swap Books")
                {
                    if (list.Contains(firstCommand) && list.Contains(secondCommand))
                    {
                        int firstIndex = list.IndexOf(firstCommand);
                        int secondIndex = list.IndexOf(secondCommand);
                        list[firstIndex] = secondCommand;
                        list[secondIndex] = firstCommand;
                    }
                }
                else if (action == "Insert Book")
                {
                    list.Add(firstCommand);
                }
                else if (action == "Check Book")
                {
                    if (int.Parse(firstCommand) >= 0 && int.Parse(firstCommand) < list.Count)
                    {
                        Console.WriteLine(list[int.Parse(firstCommand)]);
                    }
                }
            }
            Console.WriteLine(string.Join (", ", list));
        }
    }
}
