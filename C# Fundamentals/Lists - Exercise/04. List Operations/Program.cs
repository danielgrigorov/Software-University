using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

                if (token[0] == "Add")
                {
                    list.Add(int.Parse(token[1]));
                }
                else if (token[0] == "Insert")
                {
                    if (int.Parse(token[2]) < 0 || int.Parse(token[2]) > list.Count)
                    {
                        Console.WriteLine("Invalid index");
                        
                    }
                    else
                    {
                        list.Insert(int.Parse(token[2]), int.Parse(token[1]));

                    }
                }
                else if (token[0] == "Remove")
                {
                    if (int.Parse(token[1]) < 0 || int.Parse(token[1]) > list.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(int.Parse(token[1]));

                    }
                }
                else if (token[1] == "left")
                {
                    for (int i = 0; i < int.Parse(token[2]); i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (token[1] == "right")
                {
                    for (int i = 0; i < int.Parse(token[2]); i++)
                    {
                        list.Insert(0, list[list.Count -1]);
                        list.RemoveAt(list.Count - 1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
