using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var queue = new Queue<string>(input);

            int n = int.Parse(Console.ReadLine());

            int currentIndex = 1;

            while (queue.Count > 1)
            {
                var currentName = queue.Dequeue();

                if (currentIndex == n)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currentIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentName);
                }

                currentIndex++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
