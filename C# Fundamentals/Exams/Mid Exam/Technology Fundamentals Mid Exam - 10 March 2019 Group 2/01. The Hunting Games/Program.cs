using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int amountOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double totalWater = days * amountOfPlayers * waterPerDayPerPerson;
            double totalFood = days * amountOfPlayers * foodPerDayPerPerson;

            bool theyWillSurvive = true;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                if (groupEnergy - energyLoss <= 0)
                {
                    theyWillSurvive = false;
                    break;
                }

                groupEnergy -= energyLoss;

                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    totalWater *= 0.7;
                }

                if (i % 3 == 0)
                {
                    groupEnergy *= 1.1;
                    totalFood -= totalFood / amountOfPlayers;
                }

            }

            if (theyWillSurvive)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }

        }
    }
}
