using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Cooking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int breadAmount = 25;
            int cakeAmount = 50;
            int pastryAmout = 75;
            int fruitPieAmount = 100;

            int breadCount = 0;
            int cakeCount = 0;
            int pastryCount = 0;
            int fruitPieCount = 0;

            var liquids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(liquids);
            var stack = new Stack<int>(ingredients);

            while (true)
            {
                if (queue.Count == 0 || stack.Count == 0)
                {
                    break;
                }

                var currentQueue = queue.Peek();
                var currentStack = stack.Peek();

                if (currentQueue + currentStack == breadAmount)
                {
                    breadCount++;
                    queue.Dequeue();
                    stack.Pop();
                }

                else if (currentQueue + currentStack == cakeAmount)
                {
                    cakeCount++;
                    queue.Dequeue();
                    stack.Pop();
                }

                else if (currentQueue + currentStack == pastryAmout)
                {
                    pastryCount++;
                    queue.Dequeue();
                    stack.Pop();
                }

                else if (currentQueue + currentStack == fruitPieAmount)
                {
                    fruitPieCount++;
                    queue.Dequeue();
                    stack.Pop();
                }

                else
                {
                    queue.Dequeue();
                    currentStack += 3;
                    stack.Pop();
                    stack.Push(currentStack);
                }

            }

            if (breadCount >= 1 && cakeCount >= 1 && pastryCount >= 1 && fruitPieCount >=1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",queue)}");
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ",stack)}");
            }

            Console.WriteLine($"Bread: {breadCount}");
            Console.WriteLine($"Cake: {cakeCount}");
            Console.WriteLine($"Fruit Pie: {fruitPieCount}");
            Console.WriteLine($"Pastry: {pastryCount}");
        }
    }
}
