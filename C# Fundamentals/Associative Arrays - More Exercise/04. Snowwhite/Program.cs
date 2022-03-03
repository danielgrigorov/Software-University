using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                string[] token = input.Split(" <:> ");

                string dwarfName = token[0];
                string dwarfHatColor = token[1];
                int dwarfPhysics = int.Parse(token[2]);

                if (dict.ContainsKey(dwarfHatColor))
                {
                    if (dict[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        if (dict[dwarfHatColor][dwarfName] < dwarfPhysics)
                        {
                            dict[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                    }
                    else
                    {
                        dict[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                }
                else
                {
                    dict[dwarfHatColor] = new Dictionary<string, int>();
                    dict[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                }
            }

            var finalDict = new Dictionary<string, int>();

            foreach (var item in dict.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var item2 in item.Value)
                {
                    finalDict.Add($"({item.Key}) {item2.Key} <->", item2.Value);
                }
            }

            foreach (var item in finalDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }


        }
    }
}
