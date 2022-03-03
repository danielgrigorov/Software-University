using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var threads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var objectiveTask = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(tasks);
            var queue = new Queue<int>(threads);

            var missionAccomplished = false;

            while (!missionAccomplished)
            {
                var currentTask = stack.Peek();
                var currentThread = queue.Peek();

                if (currentTask == objectiveTask)
                {


                    stack.Pop();
                    Console.WriteLine($"Thread with value {currentThread} killed task {objectiveTask}");
                    missionAccomplished = true;

                }

                else
                {
                    if (currentThread >= currentTask)
                    {
                        stack.Pop();
                        queue.Dequeue();
                    }
                    else
                    {
                        queue.Dequeue();
                    }

                }
            }

            Console.WriteLine(string.Join(" ", queue));

        }
    }
}
