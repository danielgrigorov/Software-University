using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            foreach (var word in words)
            {
                if (word.Length %2 == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
