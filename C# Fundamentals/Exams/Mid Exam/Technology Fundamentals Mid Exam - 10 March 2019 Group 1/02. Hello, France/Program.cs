using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|")
                .ToList();

            double budget = double.Parse(Console.ReadLine());

            double profit = 0;
            double totalProfit = 0;

            List<double> profitList = new List<double>();

            for (int i = 0; i < list.Count; i++)
            {
                string[] token = list[i].Split("->");

                string type = token[0];
                double price = double.Parse(token[1]);

                if (type == "Clothes" && price <= 50 && price <= budget)
                {
                    budget -= price;
                    profit = price * 1.4;
                    profitList.Add(profit);
                    totalProfit += profit - price;
                }

                else if (type == "Shoes" && price <= 35 && price <= budget)
                {
                    budget -= price;
                    profit = price * 1.4;
                    profitList.Add(profit);
                    totalProfit += profit - price;
                }

                else if (type == "Accessories" && price <= 20.50 && price <= budget)
                {
                    budget -= price;
                    profit = price * 1.4;
                    profitList.Add(profit);
                    totalProfit += profit - price;
                }

            }

            for (int i = 0; i < profitList.Count; i++)
            {
                Console.Write($"{profitList[i]:f2}" + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {totalProfit:f2}");

            if ((budget + profitList.Sum()) >= 150)
            {
                Console.WriteLine("Hello, France!");
            }

            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
