using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Racer
    {
        public Racer(string name, int age, string country,Car car)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
            this.car = car;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public Car car { get; set; }

        public override string ToString()
        {
            return $"Racer: {this.Name}, {this.Age} ({this.Country})";
        }
    }
}
