using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;

        private int deadAstronauts = 0;
        private int exploredPlanets = 0;

        public Controller()
        {
            this.astronauts = new AstronautRepository();
            this.planets = new PlanetRepository();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            if (type != "Biologist" && type != "Geodesist" && type != "Meteorologist")
            {
                throw new InvalidOperationException("Astronaut type doesn't exists!");
            }

            else if (type == "Biologist")
            {
                var astronaut = new Biologist(astronautName);
                this.astronauts.Add(astronaut);
            }

            else if (type == "Geodesist")
            {
                var astronaut = new Geodesist(astronautName);
                this.astronauts.Add(astronaut);
            }

            else if (type == "Meteorologist")
            {
                var astronaut = new Meteorologist(astronautName);
                this.astronauts.Add(astronaut);
            }

            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            var planet = new Planet(planetName);
            this.planets.Add(planet);

            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            Mission mission = new Mission();

            var planetToWorkOn = planets.FindByName(planetName);

            ICollection<IAstronaut> astronauts = this.astronauts.Models.Where(b => b.Oxygen > 60).ToList();

            if (!astronauts.Any())
            {
                throw new InvalidOperationException("You need at least one astronaut to explore the planet!");
            }

            while (astronauts.Any(x=>x.CanBreath) && planetToWorkOn.Items.Any())
            {
                var currentAstronaut = astronauts.FirstOrDefault(x=>x.CanBreath);


                mission.Explore(planetToWorkOn, astronauts);
            }
            exploredPlanets++;

            return $"Planet: {planetName} was explored! Exploration finished with {astronauts.Where(x=>x.CanBreath == false).Count()} dead astronauts!";

        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{exploredPlanets} planets were explored!");
            sb.AppendLine("Astronauts info:");

            foreach (var astronaut in this.astronauts.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");

                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine("Bag items: none");
                }

                else
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astronaut.Bag.Items)}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronautToRemove = this.astronauts.FindByName(astronautName);

            if (astronautToRemove == null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }
            else
            {
                this.astronauts.Remove(astronautToRemove);
            }

            return $"Astronaut {astronautName} was retired!";
        }
    }
}
