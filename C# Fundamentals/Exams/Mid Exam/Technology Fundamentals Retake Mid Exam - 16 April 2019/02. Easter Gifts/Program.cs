using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "No Money")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                string giftName = token[1];

                int giftIndex = 0;

                if (token.Length == 3)
                {
                    giftIndex = int.Parse(token[2]);
                }

                if (action == "OutOfStock")
                {
                    if (list.Contains(giftName))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == giftName)
                            {
                                list[i] = "None";
                            }
                        }
                    }

                }

                else if (action == "Required" && giftIndex >= 0 && giftIndex < list.Count)
                {
                    list[giftIndex] = giftName;
                }

                else if (action == "JustInCase" )
                {
                    list[list.Count - 1] = giftName;
                }
            }

            list.RemoveAll(x => x == "None");

            Console.WriteLine(string.Join (" ", list));
        }
    }
}
