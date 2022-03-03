using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string name = input[1];
                string registrationPlate = string.Empty;
                if (input.Length == 3)
                {
                     registrationPlate = input[2];
                }

                if (command == "register")
                {
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[name]}");
                    }
                    else
                    {
                        dict[name] = registrationPlate;
                        Console.WriteLine($"{name} registered {registrationPlate} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        dict.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
