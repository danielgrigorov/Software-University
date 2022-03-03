using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, int>();

            string legendaryItem = string.Empty;

            while (true)
            {
                string[] current = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < current.Length; i += 2)
                {
                    int currentValue = int.Parse(current[i]);
                    string currentMaterial = current[i + 1].ToLower();

                    if (!dict.ContainsKey(currentMaterial))
                    {
                        dict[currentMaterial] = 0;
                    }
                    dict[currentMaterial] += currentValue;

                    if (dict[currentMaterial] >= 250)
                    {

                        if (currentMaterial == "shards" || currentMaterial == "fragments" || currentMaterial == "motes")
                        {
                            legendaryItem = currentMaterial;
                            dict[currentMaterial] -= 250;

                            if (legendaryItem == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }

                            else if (legendaryItem == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }

                            else if (legendaryItem == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }

                            var finalDict = new Dictionary<string, int>();

                            if (dict.ContainsKey("shards"))
                            {
                                finalDict["shards"] = dict["shards"];
                            }
                            else
                            {
                                finalDict["shards"] = 0;
                            }

                            if (dict.ContainsKey("fragments"))
                            {
                                finalDict["fragments"] = dict["fragments"];
                            }
                            else
                            {
                                finalDict["fragments"] = 0;
                            }

                            if (dict.ContainsKey("motes"))
                            {
                                finalDict["motes"] = dict["motes"];
                            }
                            else
                            {
                                finalDict["motes"] = 0;
                            }

                            dict.Remove("shards");
                            dict.Remove("fragments");
                            dict.Remove("motes");

                            finalDict = finalDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                            foreach (var item in finalDict)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }

                            foreach (var item in dict)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }

                            return;
                        }

                    }
                }
            }
        }
    }
}
