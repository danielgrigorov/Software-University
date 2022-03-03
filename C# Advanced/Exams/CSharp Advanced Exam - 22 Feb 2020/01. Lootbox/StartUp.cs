using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Guild
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstLootBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var secondLootBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(firstLootBox);
            var stack = new Stack<int>(secondLootBox);

            int collection = 0;

            while (true)
            {
                if (!stack.Any() || !queue.Any())
                {
                    break;
                }
                int currentStack = stack.Pop();
                int currentQueue = queue.Peek();

                int sum = currentQueue + currentStack;

                if (sum % 2 == 0)
                {
                    collection += sum;
                    queue.Dequeue();
                }
                else
                {
                    queue.Enqueue(currentStack);
                }
            }

            if (!queue.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (collection >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collection}");
            }
        }
    }
}
