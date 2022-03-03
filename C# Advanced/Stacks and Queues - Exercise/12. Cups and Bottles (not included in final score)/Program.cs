using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(bottles);

            var queue = new Queue<int>(cups);

            int counter = 0;

            while (true)
            {
                int currentBottle = stack.Peek();
                int currentCup = queue.Peek();

                if (currentBottle >= currentCup)
                {
                    counter += currentBottle - currentCup;
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    while (currentCup > 0)
                    {
                        currentBottle = stack.Peek();

                        if (currentBottle >= currentCup)
                        {
                            counter += currentBottle - currentCup;
                            currentCup -= currentBottle;
                            queue.Dequeue();
                            stack.Pop();
                        }
                        else
                        {
                            currentCup -= currentBottle;
                            stack.Pop();
                        }
                    }

                }

                if (queue.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", stack)}");
                    Console.WriteLine($"Wasted litters of water: {counter}");
                    break;
                }

                if (stack.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", queue)}");
                    Console.WriteLine($"Wasted litters of water: {counter}");
                    break;
                }
            }
        }
    }
}
