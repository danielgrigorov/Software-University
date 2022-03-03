using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Craft!")
                {
                    break;
                }

                string[] token = command.Split(" - ");
                string action = token[0];
                string firstCommand = token[1];

                if (action == "Collect")
                {
                    if (!list.Contains(firstCommand))
                    {
                        list.Add(firstCommand);
                    }
                }
                else if (action == "Drop")
                {
                    if (list.Contains(firstCommand))
                    {
                        list.Remove(firstCommand);
                    }
                }
                else if (action == "Combine Items")
                {
                    string[] combineItems = firstCommand.Split(":");
                    string firstCombineItems = combineItems[0];
                    string secondCombineItems = combineItems[1];

                    if (list.Contains(firstCombineItems))
                    {
                        int currentIndex = list.IndexOf(firstCombineItems);
                        list.Insert(currentIndex + 1, secondCombineItems);
                    }
                }
                else if (action == "Renew")
                {
                    if (list.Contains(firstCommand))
                    {
                        list.Add(firstCommand);
                        list.Remove(firstCommand);
                    }
                }
            }
            Console.WriteLine(string.Join (", ", list));
        }
    }
}
