using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|")
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                string firstCommand = string.Empty;
                int secondCommand = 0;

                if (token.Length == 2)
                {
                    firstCommand = token[1];
                }
                if (token.Length == 3)
                {
                    firstCommand = token[1];
                    secondCommand = int.Parse(token[2]);
                }

                if (action == "Move" && firstCommand == "Left")
                {
                    if (secondCommand-1 >=0 && secondCommand < list.Count)
                    {
                        string temp = list[secondCommand - 1];
                        list[secondCommand - 1] = list[secondCommand];
                        list[secondCommand] = temp;
                    }
                }

                else if (action == "Move" && firstCommand == "Right")
                {
                    if (secondCommand+1 < list.Count && secondCommand >= 0)
                    {
                        string temp = list[secondCommand + 1];
                        list[secondCommand + 1] = list[secondCommand];
                        list[secondCommand] = temp;
                    }
                }

                else if (action == "Check" && firstCommand == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i %2 == 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (action == "Check" && firstCommand == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i %2 == 1)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"You crafted {string.Join("", list)}!");
        }
    }
}
