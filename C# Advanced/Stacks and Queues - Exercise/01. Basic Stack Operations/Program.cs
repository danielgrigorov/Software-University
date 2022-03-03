using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(input2);

            if (stack.Any())
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
                }

               
            }

            if (stack.Any())
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                if (!stack.Contains(x))
                {
                    Console.WriteLine(stack.Min());
                }
            }
            
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
