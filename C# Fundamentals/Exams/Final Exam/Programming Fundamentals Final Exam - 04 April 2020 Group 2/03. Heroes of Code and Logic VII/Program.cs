using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentHero = Console.ReadLine();
                string[] token = currentHero.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = token[0];
                int HP = int.Parse(token[1]);
                int MP = int.Parse(token[2]);

                dict.Add(heroName, new Dictionary<string, int>());
                dict[heroName].Add("HP", HP);
                dict[heroName].Add("MP", MP);
            }

            while (true)
            {
                string currentCommand = Console.ReadLine();

                if (currentCommand == "End")
                {
                    break;
                }

                string[] token = currentCommand.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = token[0];
                string currentHero = token[1];
                int amount = 0;
                string attacker = string.Empty;

                if (command == "CastSpell")
                {
                    amount = int.Parse(token[2]);
                    attacker = token[3];

                    if (dict[currentHero]["MP"] >= amount)
                    {
                        dict[currentHero]["MP"] -= amount;
                        Console.WriteLine($"{currentHero} has successfully cast {attacker} and now has {dict[currentHero]["MP"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentHero} does not have enough MP to cast {attacker}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    amount = int.Parse(token[2]);
                    attacker = token[3];

                    dict[currentHero]["HP"] -= amount;

                    if (dict[currentHero]["HP"] > 0)
                    {
                        Console.WriteLine($"{currentHero} was hit for {amount} HP by {attacker} and now has {dict[currentHero]["HP"]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentHero} has been killed by {attacker}!");
                        dict.Remove(currentHero);
                    }
                }
                else if (command == "Recharge")
                {
                    amount = int.Parse(token[2]);

                    if (dict[currentHero]["MP"] + amount > 200)
                    {
                        Console.WriteLine($"{currentHero} recharged for {200 - dict[currentHero]["MP"]} MP!");
                        dict[currentHero]["MP"] = 200;
                    }
                    else
                    {
                        dict[currentHero]["MP"] += amount;
                        Console.WriteLine($"{currentHero} recharged for {amount} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    amount = int.Parse(token[2]);

                    if (dict[currentHero]["HP"] + amount > 100)
                    {
                        Console.WriteLine($"{currentHero} healed for {100 - dict[currentHero]["HP"]} HP!");
                        dict[currentHero]["HP"] = 100;
                    }
                    else
                    {
                        dict[currentHero]["HP"] += amount;
                        Console.WriteLine($"{currentHero} healed for {amount} HP!");

                    }
                }
            }

            if (dict.Count > 0)
            {
                dict = dict.OrderByDescending(x => x.Value["HP"]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in dict)
                {
                    Console.WriteLine($"{item.Key}");
                    Console.WriteLine($"  HP: {item.Value["HP"]}");
                    Console.WriteLine($"  MP: {item.Value["MP"]}");
                }
            }

            
        }
    }
}
