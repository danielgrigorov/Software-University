using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            int currentIndex = 0;
            int failedCount = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Love!")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                int firstCommand = int.Parse(token[1]);

                if (firstCommand + currentIndex >= list.Count )
                {
                    if (list[0] == 0)
                    {
                        Console.WriteLine("Place 0 already had Valentine's day.");
                    }
                    else
                    {
                        list[0] -= 2;

                        if (list[0] == 0)
                        {
                            Console.WriteLine("Place 0 has Valentine's day.");
                        }
                    }
                }

                else if (firstCommand + currentIndex < list.Count)
                {
                    if (list[firstCommand + currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {firstCommand + currentIndex} already had Valentine's day.");

                    }
                    else
                    {
                        list[firstCommand + currentIndex] -= 2;

                        if (list[firstCommand + currentIndex] == 0)
                        {
                            Console.WriteLine($"Place {firstCommand + currentIndex} has Valentine's day.");
                        }
                    }
                }

                if (firstCommand + currentIndex < list.Count)
                {
                    currentIndex = firstCommand + currentIndex;
                }
                else
                {
                    currentIndex = 0;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 0)
                {
                    failedCount++;
                }
            }

            if (failedCount > 0)
            {
                Console.WriteLine($"Cupid's last position was {currentIndex}.");
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
            else
            {
                Console.WriteLine($"Cupid's last position was {currentIndex}.");
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
