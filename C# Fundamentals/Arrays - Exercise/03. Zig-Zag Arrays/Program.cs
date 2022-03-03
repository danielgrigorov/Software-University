using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (counter %2 == 1)
                {
                    Array.Reverse(currentRow);
                }

                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        array1[i] = currentRow[j];

                    }
                    else
                    {
                        array2[i] = currentRow[j];
                    }
                }
                counter++;
            }
            Console.WriteLine(string.Join(" ",array1));
            Console.WriteLine(string.Join(" ",array2));
        }
    }
}
