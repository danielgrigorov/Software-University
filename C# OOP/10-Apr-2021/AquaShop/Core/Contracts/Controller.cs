using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core.Contracts
{
    public class Controller : IController
    {
        private List<IAquarium> aquariums;
        private List<IDecoration> decorations;
        public Controller()
        {
            this.aquariums = new List<IAquarium>();
            this.decorations = new List<IDecoration>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType != "FreshwaterAquarium" && aquariumType != "SaltwaterAquarium")
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }
            else if (aquariumType == "FreshwaterAquarium")
            {
                FreshwaterAquarium freshWaterAquarium = new FreshwaterAquarium(aquariumName);
                aquariums.Add(freshWaterAquarium);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                SaltwaterAquarium salterWaterAquarium = new SaltwaterAquarium(aquariumName);
                aquariums.Add(salterWaterAquarium);
            }

            return ($"Successfully added {aquariumType}.");

        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }
            else if (decorationType == "Ornament")
            {
                Ornament ornament = new Ornament();
                decorations.Add(ornament);
            }
            else if (decorationType == "Plant")
            {
                Plant plant = new Plant();
                decorations.Add(plant);
            }

            return ($"Successfully added {decorationType}.");
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            var aquariumToAddTo = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            if (aquariumToAddTo.GetType().Name == nameof(FreshwaterAquarium) && fishType == "SaltwaterFish")
            {
                return "Water not suitable.";
            }
            else if (aquariumToAddTo.GetType().Name == nameof(SaltwaterAquarium) && fishType == "FreshwaterFish")
            {
                return "Water not suitable.";
            }
            else
            {
                if (fishType == "FreshwaterFish")
                {
                    FreshwaterFish freshWaterFish = new FreshwaterFish(fishName, fishSpecies, price);
                    aquariumToAddTo.AddFish(freshWaterFish);
                }
                else if (fishType == "SaltwaterFish")
                {
                    SaltwaterFish saltWaterFish = new SaltwaterFish(fishName, fishSpecies, price);
                    aquariumToAddTo.AddFish(saltWaterFish);
                }
                return ($"Successfully added {fishType} to {aquariumName}.");
            }

        }

        public string CalculateValue(string aquariumName)
        {
            var aquariumToCalculate = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            var result = 0m;

            foreach (var fish in aquariumToCalculate.Fish)
            {
                result += fish.Price;
            }

            foreach (var decoration in aquariumToCalculate.Decorations)
            {
                result += decoration.Price;
            }

            return ($"The value of Aquarium {aquariumName} is {result:f2}.");

        }

        public string FeedFish(string aquariumName)
        {
            var aquariumToFeed = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            foreach (var fish in aquariumToFeed.Fish)
            {
                fish.Eat();
            }
            return ($"Fish fed: {aquariumToFeed.Fish.Count}");
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decorationToInsert = this.decorations.FirstOrDefault(x => x.GetType().Name == decorationType);
            var aquariumToAddTo = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if (decorationToInsert == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }
            else
            {
                aquariumToAddTo.AddDecoration(decorationToInsert);
                decorations.Remove(decorationToInsert);
                return ($"Successfully added {decorationType} to {aquariumName}.");
            }
        }

        public string Report()
        {
            var sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine($"{aquarium.Name} ({aquarium.GetType().Name}):");

                if (aquarium.Fish.Count == 0)
                {
                    sb.AppendLine("Fish: none");
                }
                else
                {
                    var fishNames = aquarium.Fish.Select(x => x.Name);

                    sb.AppendLine($"Fish: {string.Join(", ", fishNames)}");
                }

                sb.AppendLine($"Decorations: {aquarium.Decorations.Count}");

                sb.AppendLine($"Comfort: {aquarium.Comfort}");

            }
            return sb.ToString().TrimEnd();

        }
    }
}
