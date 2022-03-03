using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var robots = new List<Robots>();
            var citizens = new List<Citizens>();
            var ids = new List<string>();
            var birthDays = new List<string>();
            var rebels = new List<Rebel>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs.Length == 4)
                {
                    string currentName = commandArgs[0];
                    int currentAge = int.Parse(commandArgs[1]);
                    string currentId = commandArgs[2];
                    string currentBirthDate = commandArgs[3];

                    Citizens citizen = new Citizens(currentName, currentAge, currentId, currentBirthDate);

                    citizens.Add(citizen);
                    ids.Add(currentId);
                    birthDays.Add(currentBirthDate);
                    citizen.BuyFood(10);
                }

                else if (commandArgs.Length == 3)
                {
                    string currentName = commandArgs[0];
                    int currentAge = int.Parse(commandArgs[1]);
                    string currentGroup = commandArgs[2];

                    Rebel rebel = new Rebel(currentName, currentAge, currentGroup);

                    rebels.Add(rebel);

                    rebel.BuyFood(5);

                }
            }

            int totalFood = 0;

            while (true)
            {
                string currentFoodBuyer = Console.ReadLine();

                if (currentFoodBuyer == "End")
                {
                    break;
                }

                var current = citizens.FirstOrDefault(x => x.Name == currentFoodBuyer);

                if (current != null)
                {
                    totalFood += 10;
                    continue;
                }

                var current2 = rebels.FirstOrDefault(x => x.Name == currentFoodBuyer);

                if (current2 != null)
                {
                    totalFood += 5;
                }
            }

            Console.WriteLine(totalFood);
            //foreach (var robot in robots)
            //{
            //    string currentId = robot.Id.Substring(robot.Id.Length - fakeId.Length);

            //    if (currentId == fakeId)
            //    {
            //        Console.WriteLine(robot.Id);
            //    }
            //}
        }
    }
}
