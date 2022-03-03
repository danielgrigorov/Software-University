using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }

    }
}
