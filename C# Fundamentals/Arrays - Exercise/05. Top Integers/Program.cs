using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();


            for (long i = 0; i < array.Length; i++)
            {
                bool bigger = true;

                for (long j = 1 + i; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        bigger = false;
                    }
                }
                if (bigger)
                {
                    Console.Write(array[i] + " ");
                }

            }
        }
    }
}
