using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;

            bool noNumber = true;

            // 1 2 3 3

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {

                    if (i == array.Length - 1)
                    {
                        break;
                    }
                    rightSum += array[k];

                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    noNumber = false;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (noNumber)
            {
                Console.WriteLine("no");
            }
        }
    }
}
