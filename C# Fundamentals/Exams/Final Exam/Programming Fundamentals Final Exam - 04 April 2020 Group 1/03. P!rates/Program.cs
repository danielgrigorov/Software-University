using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var townsPeople = new Dictionary<string, int>();
            var townsGold = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Sail")
                {
                    break;
                }

                string[] token = input.Split("||");

                if (!townsPeople.ContainsKey(token[0]))
                {
                    townsPeople.Add(token[0], int.Parse(token[1]));
                    townsGold.Add(token[0], int.Parse(token[2]));
                }
                else
                {
                    townsPeople[token[0]] += int.Parse(token[1]);
                    townsGold[token[0]] += int.Parse(token[2]);
                }
            }



            while (true)
            {
                string input2 = Console.ReadLine();

                if (input2 == "End")
                {
                    break;
                }

                string[] token = input2.Split("=>");

                string command = token[0];
                string town = token[1];
                int people = 0;
                int gold1 = 0;
                int gold2 = 0;

                if (token.Length == 3)
                {
                    gold1 = int.Parse(token[2]);
                }
                else if (token.Length == 4)
                {
                    people = int.Parse(token[2]);
                    gold2 = int.Parse(token[3]);
                }

                if (command == "Plunder")
                {
                    townsPeople[town] -= people;
                    townsGold[town] -= gold2;
                    Console.WriteLine($"{town} plundered! {gold2} gold stolen, {people} citizens killed.");

                    if (townsPeople[town] <= 0 || townsGold[town] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        townsPeople.Remove(town);
                        townsGold.Remove(town);
                    }
                }
                else if (command == "Prosper")
                {
                    if (gold1 < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        townsGold[town] += gold1;
                        Console.WriteLine($"{gold1} gold added to the city treasury. {town} now has {townsGold[town]} gold.");
                    }
                }
            }

            var townsFinal = new Dictionary<string, Dictionary<int, int>>();

            townsGold = townsGold.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in townsGold)
            {
                foreach (var item2 in townsPeople)
                {
                    if (item.Key == item2.Key)
                    {
                        townsFinal.Add(item.Key, new Dictionary<int, int>());
                        townsFinal[item.Key].Add(item2.Value, item.Value);
                    }
                }
            }

            if (townsFinal.Keys.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {townsFinal.Keys.Count} wealthy settlements to go to:");

                foreach (var item in townsFinal)
                {
                    foreach (var item2 in item.Value)
                    {
                        Console.WriteLine($"{item.Key} -> Population: {item2.Key} citizens, Gold: {item2.Value} kg");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
