using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var defense = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(defense);
            var stack = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                var currentOrc = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < currentOrc.Length; j++)
                {
                    stack.Push(currentOrc[j]);
                }

                if (i %3 == 0)
                {
                    int addition = int.Parse(Console.ReadLine());
                    queue.Enqueue(addition);
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    break;
                }


                while (stack.Any() && queue.Any())
                {
                    var currentQueue = queue.Peek();
                    var currentStack = stack.Peek();

                    if (currentStack > currentQueue)
                    {
                        currentStack -= currentQueue;

                        if (currentStack <= 0)
                        {
                            stack.Pop();
                        }
                        queue.Dequeue();
                        stack.Pop();
                        stack.Push(currentStack);
                    }

                    else if (currentStack < currentQueue)
                    {
                        currentQueue -= currentStack;
                        stack.Pop();
                        queue.Dequeue();
                        queue = new Queue<int>(queue.Reverse());
                        queue.Enqueue(currentQueue);
                        queue = new Queue<int>(queue.Reverse());
                    }
                    else if (currentStack == currentQueue)
                    {
                        stack.Pop();
                        queue.Dequeue();
                    }
                }

               

                if (i +1 >n)
                {
                    Console.WriteLine("The people successfully repulsed the orc's attack.");
                    break;
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    break;
                }
            }

            if (stack.Any())
            {
                Console.WriteLine($"Orcs left: {string.Join(", ",stack)}");
            }
            if (queue.Any())
            {
                Console.WriteLine($"Plates left: {string.Join(", ",queue)}");
            }
        }
    }
}
