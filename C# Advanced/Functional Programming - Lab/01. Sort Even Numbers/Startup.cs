using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x=>x %2 == 0).ToList();

            input.Sort();

            Console.WriteLine(string.Join(", ",input));


        }
    }
}
