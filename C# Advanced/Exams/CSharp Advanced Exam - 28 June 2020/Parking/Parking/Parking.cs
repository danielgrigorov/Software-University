using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public List<Car> Data 
        { 
            get => this.data; 
        }

        public void Add(Car car)
        {
            if (data.Count + 1 <= this.Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            var carToRemove = this.data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);

            if (carToRemove == null)
            {
                return false;
            }
            this.data.Remove(carToRemove);
                return true;
        }

        public Car GetLatestCar()
        {
            if (data.Count != 0)
            {
                Car latestCar = this.data.OrderByDescending(x => x.Year).ToArray().FirstOrDefault();

                return latestCar;
            }
            return null;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car getCar = this.data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);

            if (getCar == null)
            {
                return null;
            }

            return getCar;
        }

        public int Count => this.data.Count();

        public string GetStatistics()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var cars in this.data)
            {
                sb.AppendLine($"{cars}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
