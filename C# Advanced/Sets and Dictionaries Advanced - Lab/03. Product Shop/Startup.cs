using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Startup
    {
        static void Main(string[] args)
        {

            var dict = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var current = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string currentShop = current[0];

                if (currentShop == "Revision")
                {
                    break;
                }

                string currentProduct = current[1];
                double currentPrice = double.Parse(current[2]);

                if (!dict.ContainsKey(currentShop))
                {
                    dict[currentShop] = new Dictionary<string, double>();
                }

                dict[currentShop][currentProduct] = currentPrice;

            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"Product: {item2.Key}, Price: {item2.Value}");
                }
            }
        }
    }
}
