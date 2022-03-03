using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {

            var sideMembers = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains(" | "))
                {
                    string[] token = input.Split(" | ");

                    string side = token[0];
                    string memberName = token[1];

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }

                    bool memberExists = false;

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(memberName))
                        {
                            memberExists = true;
                            break;
                        }
                    }

                    if (!sideMembers[side].Contains(memberName) && !memberExists)
                    {
                        sideMembers[side].Add(memberName);
                    }
                }
                else
                {
                    string[] token = input.Split(" -> ");

                    string memberName = token[0];
                    string side = token[1];

                    bool memberExists = false;
                    string currentSide = string.Empty;

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(memberName))
                        {
                            memberExists = true;
                            currentSide = kvp.Key;
                            break;
                        }
                    }

                    if (memberExists)
                    {
                        sideMembers[currentSide].Remove(memberName);
                    }


                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }
                    if (!sideMembers[side].Contains(memberName))
                    {
                        sideMembers[side].Add(memberName);
                    }

                    Console.WriteLine($"{memberName} joins the {side} side!");
                }
            }

            sideMembers = sideMembers
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sideMembers)
            {
                string sideName = item.Key;
                List<string> sidesMembers = item.Value;
                sidesMembers.Sort();

                Console.WriteLine($"Side: {sideName}, Members: {sidesMembers.Count}");

                foreach (var item2 in sidesMembers)
                {
                    Console.WriteLine($"! {item2}");
                }
            }
        }
    }
}
