using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] + input[i] * 0.2;
                Console.WriteLine($"{input[i]:f2}");
            }
        }
    }
}
