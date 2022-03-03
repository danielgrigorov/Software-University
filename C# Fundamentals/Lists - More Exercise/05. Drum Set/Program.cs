using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> originalDrums = new List<int>();

            for (int i = 0; i < drums.Count; i++)
            {
                originalDrums.Add(drums[i]);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Hit it again, Gabsy!")
                {
                    break;
                }

                int currentPower = int.Parse(command);

                for (int i = 0; i < drums.Count; i++)
                {
                    if (drums[i] > currentPower)
                    {
                        drums[i] -= currentPower;
                    }

                    else
                    {
                        if (savings >= originalDrums[i] *3)
                        {
                            drums[i] = originalDrums[i];
                            savings -= originalDrums[i] * 3;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            originalDrums.RemoveAt(i);
                            i--;
                        }
                    }

                }
            }
            Console.WriteLine(string.Join (" ", drums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
