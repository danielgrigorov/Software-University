using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();

            var dict2 = new Dictionary<string, double>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "buy")
                {
                    break;
                }

                string[] input = command.Split();

                string currentProdcut = input[0];
                double currentPrice = double.Parse(input[1]);
                int currentQuantity = int.Parse(input[2]);

                if (!dict.ContainsKey(currentProdcut))
                {
                    dict[currentProdcut] = 0;
                }

                dict[currentProdcut] += currentQuantity;

                dict2[currentProdcut] = currentPrice;
            }

            var finalDict = new Dictionary<string, double>();

            foreach (var item in dict)
            {
                finalDict[item.Key] = item.Value * dict2[item.Key];
            }
            foreach (var item in finalDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
