using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.secondtry
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            var defense = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(defense);

            for (int i = 1; i <= waves; i++)
            {
                var attack = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var stack = new Stack<int>(attack);

                if (i %3 == 0)
                {
                    var additionalDefense = int.Parse(Console.ReadLine());
                    queue.Enqueue(additionalDefense);
                }

                var currentQueue = queue.Peek();


                while (stack.Any() && queue.Any())
                {
                    var currentStack = stack.Peek();

                    if (currentQueue <= 0)
                    {
                        currentQueue = queue.Peek();
                    }

                    if (currentStack > currentQueue)
                    {
                        currentStack -= currentQueue;
                        currentQueue = 0;
                        queue.Dequeue();
                        stack.Pop();
                        stack.Push(currentStack);
                    }

                    else if (currentQueue > currentStack)
                    {
                        currentQueue -= currentStack;
                        stack.Pop();
                    }
                    else if (currentQueue == currentStack)
                    {
                        stack.Pop();
                        queue.Dequeue();
                        currentQueue -= currentStack;
                    }
                }

                













                if (queue.Count == 0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    Console.WriteLine($"Orcs left: {string.Join(", ",stack)}");
                    break;
                }

                if (i +1 > waves)
                {
                    Console.WriteLine("The people successfully repulsed the orc's attack.");

                    if (currentQueue > 0)
                    {
                        queue.Dequeue();
                        Console.WriteLine($"Plates left: {currentQueue}, {string.Join(", ", queue)}");
                    }

                    else
                    {
                        Console.WriteLine($"Plates left: {string.Join(", ", queue)}");
                    }

                    
                    break;
                }

                if (stack.Count == 0)
                {
                    continue;
                }
            }

        }
    }
}
