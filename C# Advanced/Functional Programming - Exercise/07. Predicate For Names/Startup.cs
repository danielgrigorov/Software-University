using System;

namespace _07._Predicate_For_Names
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length <= n)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
