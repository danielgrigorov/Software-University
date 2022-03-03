using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.PizzaCalories
{
    public class Pizza
    {
        private string name;

        private Dough pizzaDough;


        public Pizza()
        {
            this.Toppings = new List<Topping>();
        }

        public Pizza(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name 
        { 
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15 || value.Length < 1)
                {
                    throw new InvalidOperationException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough PizzaDough { get; set; }

        public List<Topping> Toppings { get; }

        public void Add(Topping topping)
        {
            if (this.Toppings.Count > 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            this.Toppings.Add(topping);
        } 

        public double PizzaCalories()
        {
            double totalToppingCalories = this.Toppings.Select(c => c.ToppingCalories()).Sum();

            return this.PizzaDough.DoughCalories() + totalToppingCalories;
        }
    }
}
