using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum1 = 0;
            int sum2 = 0;

            bool equal = true;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    equal = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
            if (equal != false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
        }
    }
}
