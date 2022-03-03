using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("#")
                .ToList();

            int water = int.Parse(Console.ReadLine());

            double effort = 0;
            double firePutOut = 0;

            Console.WriteLine("Cells:");


            for (int i = 0; i < list.Count; i++)
            {
                string[] token = list[i].Split("=");

                string typeOfFire = token[0];
                int valueOfFire = int.Parse(token[1]);



                if (typeOfFire == "High " && valueOfFire >= 81 && valueOfFire <= 125 && water >= valueOfFire )
                {
                    water -= valueOfFire;
                    effort += 0.25 * valueOfFire;
                    firePutOut += valueOfFire;
                    Console.WriteLine($"- {valueOfFire}");
                }

                else if (typeOfFire == "Medium " && valueOfFire >= 51 && valueOfFire <= 80 && water >= valueOfFire)
                {
                    water -= valueOfFire;
                    effort += 0.25 * valueOfFire;
                    firePutOut += valueOfFire;
                    Console.WriteLine($"- {valueOfFire}");
                }

                else if (typeOfFire == "Low " && valueOfFire >= 1 && valueOfFire <= 50 && water >= valueOfFire)
                {
                    water -= valueOfFire;
                    effort += 0.25 * valueOfFire;
                    firePutOut += valueOfFire;
                    Console.WriteLine($"- {valueOfFire}");
                }
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {firePutOut}");
        }
    }
}
