using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.numberOfBadges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int NumberOfBadges
        {
            get => this.numberOfBadges;
            set => this.numberOfBadges = value;
        }

        public List<Pokemon> Pokemons 
        { 
            get => this.pokemons; 
        }
    }
}
