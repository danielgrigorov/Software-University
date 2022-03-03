using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Startup
    {
        static void Main(string[] args)
        {
            var vipList = new HashSet<string>();
            var regularList = new HashSet<string>();

            bool partyStarted = false;

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "END")
                {
                    break;
                }

                else if (current == "PARTY")
                {
                    partyStarted = true;
                }

                else if (partyStarted)
                {
                    if (vipList.Contains(current))
                    {
                        vipList.Remove(current);
                    }
                    else if (regularList.Contains(current))
                    {
                        regularList.Remove(current);
                    }
                }

                else
                {
                    if (char.IsDigit(current[0]))
                    {
                        vipList.Add(current);
                    }
                    else
                    {
                        regularList.Add(current);
                    }
                }


            }

            Console.WriteLine(vipList.Count + regularList.Count);

            foreach (var item in vipList)
            {
                Console.WriteLine(item);
            }

            foreach (var item in regularList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
