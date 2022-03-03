using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public List<Pet> Data 
        { 
            get => this.Data; 
        }

        public void Add(Pet pet)
        {
            if (this.data.Count +1 <= this.Capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            var petToRemove = this.data.FirstOrDefault(x => x.Name == name);

            if (petToRemove == null)
            {
                return false;
            }
            else
            {
                this.data.Remove(petToRemove);
                return true;
            }
        }

        public Pet GetPet(string name, string owner)
        {
            var petToGet = this.data.FirstOrDefault(x => x.Name == name && x.Owner == owner);

            if (petToGet == null)
            {
                return null;
            }
            else
            {
                return petToGet;
            }
        }

        public Pet GetOldestPet()
        {
            var oldestPet = this.data.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPet;
        }

        public int Count => this.data.Count();

        public string GetStatistics()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"The clinic has the following patients:");

            foreach (var item in data)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }

            return sb.ToString().TrimEnd();

        }
    }
}
