using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                else if (input == "Paid")
                {
                    while (queue.Any())
                    {
                        Console.WriteLine(queue.Dequeue());
                    }

                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
