using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.lasttry
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            var defense = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(defense);
            var stack = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                var attack = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                stack = new Stack<int>(attack);

                if (i %3 == 0)
                {
                    var additionalDefense = int.Parse(Console.ReadLine());
                    queue.Enqueue(additionalDefense);
                }

                while (queue.Any() && stack.Any())
                {
                    var currentStack = stack.Peek();
                    var currentQueue = queue.Peek();

                    if (currentStack > currentQueue)
                    {
                        currentStack -= currentQueue;
                        queue.Dequeue();
                        stack.Pop();
                        stack.Push(currentStack);
                    }

                    else if (currentQueue > currentStack)
                    {
                        currentQueue -= currentStack;
                        stack.Pop();
                        queue.Dequeue();
                        queue = new Queue<int>(queue.Reverse());
                        queue.Enqueue(currentQueue);
                        queue = new Queue<int>(queue.Reverse());
                    }

                    else if (currentQueue == currentStack)
                    {
                        stack.Pop();
                        queue.Dequeue();
                    }

                    if (queue.Count == 0)
                    {
                        Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                        Console.WriteLine($"Orcs left: {string.Join(", ",stack)}");
                        break;
                    }
                }
                if (queue.Count == 0)
                {
                    break;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ",queue)}");
            }
        }
    }
}
