using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] roundedNums = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(arr[i])} => {Convert.ToDecimal(roundedNums[i])}");
            }
        }
    }
}
