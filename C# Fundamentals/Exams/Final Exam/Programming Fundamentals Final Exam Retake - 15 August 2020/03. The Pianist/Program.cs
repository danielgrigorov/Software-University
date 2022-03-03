using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new SortedDictionary<string, SortedDictionary<string, string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] token = input.Split("|");

                string piece = token[0];
                string composer = token[1];
                string key = token[2];

                dict.Add(piece, new SortedDictionary<string, string>());
                dict[piece].Add("composer", composer);
                dict[piece].Add("key", key);
            }

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "Stop")
                {
                    break;
                }

                string[] token = current.Split("|");

                string command = token[0];
                string command2 = token[1];
                string command3 = string.Empty;
                string command4 = string.Empty;

                if (command == "Add")
                {
                    command3 = token[2];
                    command4 = token[3];

                    if (dict.ContainsKey(command2))
                    {
                        Console.WriteLine($"{command2} is already in the collection!");
                    }
                    else
                    {
                        dict.Add(command2, new SortedDictionary<string, string>());
                        dict[command2].Add("composer", command3);
                        dict[command2].Add("key", command4);
                        Console.WriteLine($"{command2} by {command3} in {command4} added to the collection!");
                    }
                }

                else if (command == "Remove")
                {
                    if (!dict.ContainsKey(command2))
                    {
                        Console.WriteLine($"Invalid operation! {command2} does not exist in the collection.");
                    }
                    else
                    {
                        dict.Remove(command2);
                        Console.WriteLine($"Successfully removed {command2}!");
                    }
                }

                else if (command == "ChangeKey")
                {
                    command3 = token[2];

                    if (!dict.ContainsKey(command2))
                    {
                        Console.WriteLine($"Invalid operation! {command2} does not exist in the collection.");
                    }
                    else
                    {
                        dict[command2]["key"] = command3;
                        Console.WriteLine($"Changed the key of {command2} to {command3}!");
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value["composer"]}, Key: {item.Value["key"]}");
            }
        }
    }
}
