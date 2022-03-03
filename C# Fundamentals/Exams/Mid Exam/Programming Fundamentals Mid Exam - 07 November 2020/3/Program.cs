using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> pirateShip = Console.ReadLine()
                .Split(">")
                .Select(double.Parse)
                .ToList();

            List<double> warShip = Console.ReadLine()
                .Split(">")
                .Select(double.Parse)
                .ToList();

            double maxHealth = double.Parse(Console.ReadLine());

            bool stalemate = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Retire")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                int firstCommand = 0;
                int secondCommand = 0;
                int thirdCommand = 0;

                int counter = 0;

                if (token.Length == 2)
                {
                    firstCommand = int.Parse(token[1]);
                }
                else if (token.Length == 3)
                {
                    firstCommand = int.Parse(token[1]);
                    secondCommand = int.Parse(token[2]);
                }
                else if (token.Length == 4)
                {
                    firstCommand = int.Parse(token[1]);
                    secondCommand = int.Parse(token[2]);
                    thirdCommand = int.Parse(token[3]);
                }

                if (action == "Fire" && firstCommand >= 0 && firstCommand < warShip.Count)
                {
                    warShip[firstCommand] -= secondCommand;

                    if (warShip[firstCommand] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        stalemate = false;
                        break;
                    }
                }
                else if (action == "Defend")
                {
                    for (int i = firstCommand; i <= secondCommand; i++)
                    {
                        pirateShip[i] -= thirdCommand;

                        if (pirateShip[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            stalemate = false;
                            break;
                        }
                    }
                }
                else if (action == "Repair" && firstCommand >= 0 && firstCommand < pirateShip.Count)
                {
                    if (pirateShip[firstCommand] + secondCommand <= maxHealth)
                    {
                        pirateShip[firstCommand] += secondCommand;
                    }
                    else
                    {
                        pirateShip[firstCommand] = maxHealth;
                    }
                }
                else if (action == "Status")
                {
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < 0.2 * maxHealth)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }
            }
            if (stalemate)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}
