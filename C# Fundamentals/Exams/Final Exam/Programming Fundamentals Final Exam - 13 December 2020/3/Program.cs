using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "Log out")
                {
                    break;
                }

                string[] token = current.Split(": ");

                string command = token[0];
                string userName = token[1];
                int count = 0;

                if (command == "New follower")
                {
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new Dictionary<string, int>());
                        dict[userName]["likes"] = 0;
                        dict[userName]["comments"] = 0;
                    }
                }

                else if (command == "Like")
                {
                    count = int.Parse(token[2]);

                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new Dictionary<string, int>());
                        dict[userName]["likes"] = count;
                        dict[userName]["comments"] = 0;
                    }
                    else
                    {
                        dict[userName]["likes"] += count;
                    }
                }

                else if (command == "Comment")
                {
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new Dictionary<string, int>());
                        dict[userName]["likes"] = 0;
                        dict[userName]["comments"] = 1;
                    }
                    else
                    {
                        dict[userName]["comments"] += 1;
                    }
                }

                else if (command == "Blocked")
                {
                    if (dict.ContainsKey(userName))
                    {
                        dict.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} doesn't exist.");
                    }
                }
            }

                Console.WriteLine($"{dict.Count()} followers");

            foreach (var item in dict)
            {
                item.Value["likes"] += item.Value["comments"];
            }

            dict = dict.OrderByDescending(x => x.Value["likes"]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value["likes"]}");
            }
        }
    }
}
