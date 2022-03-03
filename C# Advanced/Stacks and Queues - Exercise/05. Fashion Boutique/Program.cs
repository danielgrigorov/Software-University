using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(input);

            int rackCapacity = int.Parse(Console.ReadLine());

            int counter = 0;

            int current = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (current + stack.Peek() <= rackCapacity)
                {
                    current += stack.Pop();
                }
                else
                {
                    counter++;
                    current = 0;
                    current += stack.Pop();
                }
            }

            Console.WriteLine(counter+1);
        }
    }
}
