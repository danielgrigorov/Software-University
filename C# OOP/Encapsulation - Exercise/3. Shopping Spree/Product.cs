using System;
using System.Collections.Generic;
using System.Text;

namespace P03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name 
        { 
            get => this.name;
            private set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Name cannot be empty");
                }
                this.name = value;
            }
             
        }

        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Money cannot be negative");
                }
                this.cost = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
