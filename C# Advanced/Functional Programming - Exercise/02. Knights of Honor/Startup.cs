using System;

namespace _02._Knights_of_Honor
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Sir {input[i]}");
            }
        }
    }
}
