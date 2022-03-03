using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Racer> Data 
        { 
            get=> this.data; 
        }

        public void Add(Racer Racer)
        {
            if (this.data.Count +1 <= this.Capacity)
            {
                this.data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            var racerToRemove = this.data.FirstOrDefault(x => x.Name == name);

            if (racerToRemove == null)
            {
                return false;
            }

            this.data.Remove(racerToRemove);
            return true;
        }

        public Racer GetOldestRacer()
        {
            var oldestRacerToGet = this.data.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestRacerToGet;
        }

        public Racer GetRacer(string name)
        {
            var racerToGet = this.data.FirstOrDefault(x => x.Name == name);
            return racerToGet;
        }

        public Racer GetFastestRacer()
        {
            var fastestRacerToGet = this.data.OrderByDescending(x => x.car.Speed).FirstOrDefault();
            return fastestRacerToGet;
        }

        public int Count => this.data.Count();

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {this.Name}:");

            foreach (var item in this.data)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
