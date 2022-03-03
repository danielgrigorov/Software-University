using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int daturaBombsSum = 40;
            int cherryBombsSum = 60;
            int smokeDecoyBombsSum = 120;

            int daturaBobmsCounter = 0;
            int cherryBombsCounter = 0;
            int smokeDecoyCounter = 0;

            var bombEffects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var bombCasings = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>(bombEffects);
            var stack = new Stack<int>(bombCasings);

            while (true)
            {
                if (!queue.Any() || !stack.Any())
                {
                    break;
                }

                var currentQueue = queue.Peek();
                var currentStack = stack.Peek();
                var currentSum = currentQueue + currentStack;

                if (currentSum == daturaBombsSum)
                {
                    daturaBobmsCounter++;
                    stack.Pop();
                    queue.Dequeue();

                }
                else if (currentSum == cherryBombsSum)
                {
                    cherryBombsCounter++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (currentSum == smokeDecoyBombsSum)
                {
                    smokeDecoyCounter++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    stack.Pop();
                    stack.Push(currentStack - 5);
                }

                if (daturaBobmsCounter >= 3 && cherryBombsCounter >=3 && smokeDecoyCounter >= 3)
                {
                    break;
                }

            }

            if (daturaBobmsCounter >= 3 && cherryBombsCounter >= 3 && smokeDecoyCounter >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (queue.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",queue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (stack.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ",stack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombsCounter}");

            Console.WriteLine($"Datura Bombs: {daturaBobmsCounter}");

            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCounter}");
        }
    }
}
