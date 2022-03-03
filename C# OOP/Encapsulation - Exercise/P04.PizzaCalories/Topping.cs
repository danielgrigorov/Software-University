using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    public class Topping
    {
        private const double meatModifier = 1.2;
        private const double veggiesModifier = 0.8;
        private const double cheeseModifier = 1.1;
        private const double sauceModifier = 0.9;

        private double weight;

        private string toppingType;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        private string ToppingType 
        { 
            get => this.toppingType; 
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce" && value != "Meat")
                {
                    var valueName = value[0].ToString().ToUpper() + value.Substring(1);
                    throw new Exception($"Cannot place {valueName} on top of your pizza.");
                }
                this.toppingType = value;
            } 
        }

        private double Weight 
        { 
            get => this.weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    var valueName = this.toppingType[0].ToString().ToUpper() + this.toppingType.Substring(1);
                    throw new Exception($"{valueName} weight should be in the range [1..50].");
                }
                this.weight = value;
            } 
        }

        public double ToppingCalories()
        {
            return 2 * Weight * ToppingTypeModifier();
        }

        public double ToppingTypeModifier()
        {
            if (this.ToppingType == "meat")
            {
                return meatModifier;
            }

            else if (this.ToppingType == "veggies")
            {
                return veggiesModifier;
            }

            else if (this.ToppingType == "cheese")
            {
                return cheeseModifier;
            }

            return sauceModifier;
        }

    }
}
