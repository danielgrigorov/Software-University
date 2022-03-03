using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();

            var queue = new Queue<string>(input);

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                else 
                {
                    string song = command.Substring(4);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
