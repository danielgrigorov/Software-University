using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(input.Min());


        }
    }
}
