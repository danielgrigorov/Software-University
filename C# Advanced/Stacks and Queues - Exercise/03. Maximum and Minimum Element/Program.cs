using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (command[0] == "2")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                }
                else if (command[0] == "3")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command[0] == "4")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
