using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops;
using Easter.Repositories;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Core.Contracts
{
    public class Controller : IController
    {
        private BunnyRepository bunnies;
        private EggRepository eggs;

        private int countColoredEggs = 0;

        public Controller()
        {
            this.bunnies = new BunnyRepository();
            this.eggs = new EggRepository();
        }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType != "HappyBunny" && bunnyType != "SleepyBunny")
            {
                throw new InvalidOperationException("Invalid bunny type.");
            }
            else if (bunnyType == "HappyBunny")
            {
                var bunnyToAdd = new HappyBunny(bunnyName);
                this.bunnies.Add(bunnyToAdd);
            }
            else if (bunnyType == "SleepyBunny")
            {
                var bunnyToAdd = new SleepyBunny(bunnyName);
                this.bunnies.Add(bunnyToAdd);
            }
            return $"Successfully added {bunnyType} named {bunnyName}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            var bunnyExists = this.bunnies.FindByName(bunnyName);

            if (bunnyExists == null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }
            else
            {
                var dyeToAdd = new Dye(power);
                bunnyExists.AddDye(dyeToAdd);
                return $"Successfully added dye with power {power} to bunny {bunnyName}!";
            }
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            var eggToAdd = new Egg(eggName, energyRequired);
            eggs.Add(eggToAdd);
            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            var workshop = new Workshop();

            var eggToWorkOn = eggs.FindByName(eggName);

            ICollection<IBunny> bunnies = this.bunnies.Models.Where(b => b.Energy >= 50).OrderByDescending(b => b.Energy).ToList();

            if (!bunnies.Any())
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }

            while (bunnies.Any())
            {
                var currentBunny = bunnies.First();

                workshop.Color(eggToWorkOn, currentBunny);

                if (eggToWorkOn.IsDone())
                {
                    break;
                }

                if (!currentBunny.Dyes.Any())
                {
                    bunnies.Remove(currentBunny);
                }

                if (currentBunny.Energy == 0)
                {
                    bunnies.Remove(currentBunny);
                    this.bunnies.Remove(currentBunny);
                }
            }

            if (eggToWorkOn.IsDone())
            {
                countColoredEggs++;
                return $"Egg {eggName} is done.";
            }
            else
            {
                return $"Egg {eggName} is not done.";
            }

        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{countColoredEggs} eggs are done!");
            sb.AppendLine("Bunnies info:");

            foreach (var bunny in this.bunnies.Models)
            {
                var countInstruments = bunny.Dyes.Count(d => !d.IsFinished());

                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: {bunny.Energy}");
                sb.AppendLine($"Dyes: {countInstruments} not finished");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
