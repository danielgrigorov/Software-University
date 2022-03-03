using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise11
{
    class Program
    {

        static void Main()
        {

            var dragons = new Dictionary<string, Dictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentDrag = new Dictionary<string, int[]>();
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string type = input[0];
                string name = input[1];
                int damage = 45;
                int health = 250;
                int armor = 10;

                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    currentDrag.Add(name, new int[] { damage, health, armor });
                    dragons.Add(type, currentDrag);
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new int[] { damage, health, armor });
                    }
                    else
                    {
                        dragons[type][name] = new int[] { damage, health, armor };
                    }
                }
            }

            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({(type.Value.Select(x => x.Value[0]).Average()):F2}/{(type.Value.Select(x => x.Value[1]).Average()):F2}/{(type.Value.Select(x => x.Value[2]).Average()):F2})");

                foreach (var name in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }

            }

        }

    }

}