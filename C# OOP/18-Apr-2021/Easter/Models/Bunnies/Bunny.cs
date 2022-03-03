using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private string name;
        private int energy;

        protected Bunny(string name, int energy)
        {
            this.Dyes = new List<IDye>();
            this.Name = name;
            this.Energy = energy;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Bunny name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            protected set
            {
                
                this.energy = value > 0 ? value: 0;
            }
        }

        public ICollection<IDye> Dyes { get; }

        public void AddDye(IDye dye)
        {
            this.Dyes.Add(dye);
        }

        public virtual void Work()
        {
            this.energy -= 10;

        }
    }
}
