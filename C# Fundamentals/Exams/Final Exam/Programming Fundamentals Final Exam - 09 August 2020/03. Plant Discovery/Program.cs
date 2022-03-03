using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<double>>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] token = input.Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = token[0];
                double plantRarity = double.Parse(token[1]);

                if (!dict.ContainsKey(plantName))
                {
                    dict.Add(plantName, new Dictionary<string, List<double>>());
                    dict[plantName]["plantRarity"] = new List<double>();
                    dict[plantName]["plantRarity"].Add(plantRarity);
                }
                else
                {
                    dict[plantName]["plantRarity"][0] = plantRarity;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Exhibition")
                {
                    break;
                }

                string[] token = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = token[0];
                string rest = token[1];

                if (command == "Rate")
                {
                    string[] token2 = rest.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = token2[0];
                    double rating = double.Parse(token2[1]);

                    if (dict.ContainsKey(plant))
                    {
                        if (dict[plant].ContainsKey("plantRating"))
                        {
                            dict[plant]["plantRating"].Add(rating);
                        }
                        else
                        {
                            dict[plant]["plantRating"] = new List<double>();
                            dict[plant]["plantRating"].Add(rating);
                        }
                    }

                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update")
                {
                    string[] token2 = rest.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = token2[0];
                    double newRarity = double.Parse(token2[1]);

                    if (dict.ContainsKey(plant))
                    {
                        dict[plant]["plantRarity"][0] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset")
                {
                    if (dict.ContainsKey(rest))
                    {
                        if (dict[rest].ContainsKey("plantRating"))
                        {
                            dict[rest]["plantRating"].RemoveAll(x => x > 0);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            foreach (var item in dict)
            {
                if (item.Value.ContainsKey("plantRating"))
                {
                    if (item.Value["plantRating"].Count == 0)
                    {
                        item.Value["plantRating"] = new List<double>();
                        item.Value["plantRating"].Add(0);
                    }
                }
                else
                {
                    item.Value["plantRating"] = new List<double>();
                    item.Value["plantRating"].Add(0);
                }
                
            }

            Console.WriteLine("Plants for the exhibition:");

            dict = dict.OrderByDescending(x => x.Value["plantRarity"][0]).ThenByDescending(x => x.Value["plantRating"].Average()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value["plantRarity"][0]}; Rating: {item.Value["plantRating"].Average():f2}");
            }
        }
    }
}
