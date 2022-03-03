using System;

namespace _01._Action_Print
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
