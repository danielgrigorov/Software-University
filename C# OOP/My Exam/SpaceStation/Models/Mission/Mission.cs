using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public Mission()
        {
        }

        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            while (astronauts.Any(x=>x.Oxygen > 0))
            {

                if (!planet.Items.Any())
                {
                    break;
                }
                var currentAstronaut = astronauts.Where(x => x.Oxygen > 0).First();

                var currentItemToCollect = "";

                while (currentAstronaut.Oxygen > 0)
                {
                    currentItemToCollect = planet.Items.First();
                    
                    currentAstronaut.Bag.Items.Add(currentItemToCollect);
                    planet.Items.Remove(currentItemToCollect);
                    currentAstronaut.Breath();

                    if (currentAstronaut.Oxygen > 0)
                    {
                        break;
                    }

                }
            }
        }
    }
}
