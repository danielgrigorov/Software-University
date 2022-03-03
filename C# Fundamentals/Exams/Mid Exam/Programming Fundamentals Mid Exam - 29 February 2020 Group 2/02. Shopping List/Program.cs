using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("!")
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Go Shopping!")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                string firstCommand = token[1];
                string secondCommand = string.Empty;

                if (token.Length == 3)
                {
                    secondCommand = token[2];
                }

                if (action == "Urgent")
                {
                    if (list.Contains(firstCommand))
                    {
                        continue;
                    }
                    else
                    {
                        list.Insert(0, firstCommand);
                    }
                }
                else if (action == "Unnecessary")
                {
                    if (list.Contains(firstCommand))
                    {
                        list.Remove(firstCommand);
                    }
                }
                else if (action == "Correct")
                {
                    if (list.Contains(firstCommand))
                    {
                        int index = list.IndexOf(firstCommand);
                        list[index] = secondCommand;
                    }
                }
                else if (action == "Rearrange")
                {
                    if (list.Contains(firstCommand))
                    {
                        int index = list.IndexOf(firstCommand);
                        list.Add(firstCommand);
                        list.RemoveAt(index);
                    }
                }

            }
            Console.WriteLine(string.Join (", ", list));
        }
    }
}
