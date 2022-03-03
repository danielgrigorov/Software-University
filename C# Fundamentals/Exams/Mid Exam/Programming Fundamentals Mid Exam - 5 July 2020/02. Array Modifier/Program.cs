using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
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

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split(" ");

                string action = token[0];
                int firstCommand = 0;
                int secondCommand = 0;

                if (token.Length > 1)
                {
                    firstCommand = int.Parse(token[1]);
                    secondCommand = int.Parse(token[2]);
                }

                if (action == "swap")
                {
                    int temp = list[firstCommand];
                    list[firstCommand] = list[secondCommand];
                    list[secondCommand] = temp;
                }

                else if (action == "multiply")
                {
                    list[firstCommand] *= list[secondCommand];
                }

                else if (action == "decrease")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
