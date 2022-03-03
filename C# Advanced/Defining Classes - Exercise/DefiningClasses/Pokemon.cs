using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        private string name;
        private string element;
        private double health;
        public Pokemon(string name, string element, double health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Name 
        { 
            get=> this.name; 
            set=> this.name = value; 
        }


        public string Element 
        { 
            get=> this.element; 
            set=> this.element = value; 
        }

        public double Health 
        { 
            get=> this.health; 
            set=> this.health = value; 
        }
    }
}
