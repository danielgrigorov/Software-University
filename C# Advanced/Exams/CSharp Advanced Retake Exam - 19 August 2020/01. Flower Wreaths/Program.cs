using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var roses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var lilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(roses);
            var stack = new Stack<int>(lilies);

            int countNeededforWreath = 15;

            int countOfWreaths = 0;

            int countOfFlowersStoredForLater = 0;

            while (true)
            {
                if (!stack.Any() || !queue.Any())
                {
                    break;
                }

                int currentQueue = queue.Peek();
                int currentStack = stack.Peek();

                if (currentQueue + currentStack == countNeededforWreath)
                {
                    countOfWreaths++;
                    queue.Dequeue();
                    stack.Pop();
                }

                else if (currentQueue + currentStack > countNeededforWreath)
                {
                    stack.Pop();
                    stack.Push(currentStack - 2);
                }

                else if (currentQueue + currentStack < countNeededforWreath)
                {
                    countOfFlowersStoredForLater += currentStack + currentQueue;
                    stack.Pop();
                    queue.Dequeue();
                }

            }

            if (countOfFlowersStoredForLater > 14)
            {
                int extraWreaths = countOfFlowersStoredForLater / countNeededforWreath;
                countOfWreaths += extraWreaths;
            }

            if (countOfWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {countOfWreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - countOfWreaths} wreaths more!");
            }

        }
    }
}
