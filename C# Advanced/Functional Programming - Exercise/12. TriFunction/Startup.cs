using System;

namespace _12._TriFunction
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    sum += input[i][j];
                }

                if (sum >= n)
                {
                    Console.WriteLine(input[i]);
                    return;
                }
                else
                {
                    sum = 0;
                }
            }
        }
    }
}
