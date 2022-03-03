using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models
{
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;

        private List<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) : base(id, manufacturer, model, price, overallPerformance)
        {
            this.Id = id;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.OverallPerformance = overallPerformance;
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components { get; private set; }

        public IReadOnlyCollection<IPeripheral> Peripherals { get; private set; }

        public void AddComponent(IComponent component)
        {
            var componentExists = this.components.FirstOrDefault(x=>x.GetType().Name == component.GetType().Name);

            if (componentExists != null)
            {
                throw new ArgumentException($"Component {component.GetType().Name} already exists in {componentExists.GetType().Name} with Id {componentExists.Id}.");
            }

            this.components.Add(component);

        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new NotImplementedException();
        }

        public IComponent RemoveComponent(string componentType)
        {
            var componentExists = this.components.FirstOrDefault(x => x.GetType().Name == componentType);

            if (this.components.Count == 0 || componentExists == null)
            {
                throw new ArgumentException($"Component {componentType} does not exist in {componentType} with Id {this.Id}.");
            }

            this.components.Remove(componentExists);

            return componentExists;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id})");
            sb.AppendLine($" Components ({this.Components.Count}):");

            for (int i = 0; i < this.Components.Count; i++)
            {
                sb.AppendLine(this.components[i].ToString());
            }

            sb.AppendLine($" Peripherals ({this.Peripherals.Count}); Average Overall Performance ({this.OverallPerformance}):");

            for (int i = 0; i < this.peripherals.Count; i++)
            {
                sb.AppendLine($"  {this.peripherals[i].ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
