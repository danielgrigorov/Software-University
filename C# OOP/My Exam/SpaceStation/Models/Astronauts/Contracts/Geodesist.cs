using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts.Contracts
{
    public class Geodesist : Astronaut
    {
        public Geodesist(string name) : base(name, 50)
        {
        }
    }
}
