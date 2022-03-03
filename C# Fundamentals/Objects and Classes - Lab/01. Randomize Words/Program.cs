using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            var Random = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                var item1 = Random.Next(0, list.Count);
                var item1Bash = list[item1];

                var item2Bash = list[i];

                list[i] = item1Bash;
                list[item1] = item2Bash;

            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
