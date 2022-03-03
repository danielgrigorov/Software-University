using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string currentCar = Console.ReadLine();

                string[] token = currentCar.Split("|");

                string car = token[0];
                int mileage = int.Parse(token[1]);
                int fuel = int.Parse(token[2]);

                dict.Add(car, new Dictionary<string, int>());
                dict[car]["mileage"] = mileage;
                dict[car]["fuel"] = fuel;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                string[] token = input.Split(" : ");

                string command = token[0];
                string car = token[1];
                int command2 = int.Parse(token[2]);
                int command3 = 0;

                if (command == "Drive")
                {
                    command3 = int.Parse(token[3]);

                    if (command3 > dict[car]["fuel"])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        dict[car]["fuel"] -= command3;
                        dict[car]["mileage"] += command2;
                        Console.WriteLine($"{car} driven for {command2} kilometers. {command3} liters of fuel consumed.");

                        if (dict[car]["mileage"] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            dict.Remove(car);
                        }

                    }
                }

                else if (command == "Refuel")
                {
                     command2 = int.Parse(token[2]);


                    if (dict[car]["fuel"] + command2 > 75)
                    {
                        Console.WriteLine($"{car} refueled with {75 - dict[car]["fuel"]} liters");
                        dict[car]["fuel"] = 75;

                    }
                    else
                    {
                        dict[car]["fuel"] += command2;
                        Console.WriteLine($"{car} refueled with {command2} liters");
                    }
                }

                else if (command == "Revert")


                {
                    command2 = int.Parse(token[2]);

                    if (dict[car]["mileage"] - command2 < 10000)
                    {
                        dict[car]["mileage"] = 10000;
                    }
                    else
                    {
                        dict[car]["mileage"] -= command2;
                        Console.WriteLine($"{car} mileage decreased by {command2} kilometers");
                    }
                }
            }

            dict = dict.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value["mileage"]} kms, Fuel in the tank: {item.Value["fuel"]} lt.");
            }
        }
    }
}
