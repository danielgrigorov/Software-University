using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(input);

            Console.WriteLine(queue.Max());

            for (int i = 0; i < input.Length; i++)
            {
                if (foodQuantity >= queue.Peek())
                {
                    foodQuantity -= queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
