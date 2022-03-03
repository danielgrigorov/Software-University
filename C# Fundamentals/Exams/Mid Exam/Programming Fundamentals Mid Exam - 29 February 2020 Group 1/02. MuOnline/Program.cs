using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|")
                .ToList();

            int health = 100;
            int bitcoins = 0;
            int counter = 0;

            bool prevurtane = true;

            for (int i = 0; i < list.Count; i++)
            {
                string[] command = list[i].Split();

                string action = command[0];
                int currentPoints = int.Parse(command[1]);

                counter++;

                if (action == "potion")
                {

                    if (health + currentPoints <= 100)
                    {
                        health += currentPoints;
                        Console.WriteLine($"You healed for {currentPoints} hp.");

                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");

                        health = 100;

                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (action == "chest")
                {
                    Console.WriteLine($"You found {currentPoints} bitcoins.");
                    bitcoins += currentPoints;
                }
                else
                {
                    health -= currentPoints;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {action}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {action}.");
                        Console.WriteLine($"Best room: {counter}");
                        prevurtane = false;
                        break;
                    }
                }
            }
            if (prevurtane)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
