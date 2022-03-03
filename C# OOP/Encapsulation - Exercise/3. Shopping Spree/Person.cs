using System;
using System.Collections.Generic;
using System.Text;

namespace P03.ShoppingSpree
{
    public class Person


    {
        private string name;

        private decimal money;

        private List<Product> bag;

        public Person()
        {
            this.bag = new List<Product>();
        }
        public Person(string name, decimal money)
            : this()
        {
            this.Name = name;
            this.Money = money;
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

        public decimal Money 
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Money canot be negative");
                }
                this.money = value;
            } 
        }

        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly();



        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bag.Add(product);
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ? string.Join(", ", this.Bag) : "Nothing bought";

            return $"{this.name} - {productsOutput}";
        }
    }
}
