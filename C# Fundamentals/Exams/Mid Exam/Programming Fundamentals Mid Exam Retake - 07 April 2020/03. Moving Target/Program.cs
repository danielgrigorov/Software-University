using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                

                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                int firstCommand = int.Parse(token[1]);
                int secondCommand = int.Parse(token[2]);

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= 0)
                    {
                        list.RemoveAt(i);
                    }
                }

                if (action == "Shoot" && firstCommand >=0 && firstCommand < list.Count)
                {
                    list[firstCommand] -= secondCommand;

                    if (list[firstCommand] <= 0)
                    {
                        list.RemoveAt(firstCommand);
                    }
                }

                else if (action == "Add")
                {
                    if (firstCommand >= 0 && firstCommand < list.Count)
                    {
                        list.Insert(firstCommand, secondCommand);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                else if (action == "Strike")
                {
                    if (firstCommand < 0 || firstCommand >= list.Count || (firstCommand - secondCommand) < 0 || (firstCommand+secondCommand) >= list.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    
                    else
                    {
                        for (int i = 0; i < secondCommand; i++)
                        {
                            list.RemoveAt(firstCommand + 1);
                        }
                        for (int i = 0; i < secondCommand; i++)
                        {
                            list.RemoveAt(firstCommand - 1);
                        }

                        list.RemoveAt(firstCommand - secondCommand);
                    }

                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= 0)
                    {
                        list.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine(string.Join("|", list));
        }
    }
}
