using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    public class Dough
    {
        private const double whiteModifier = 1.5;
        private const double wholeGrainModifier = 1;
        private const double crispyModifier = 0.9;
        private const double chewyModifier = 1.1;
        private const double homeMadeModifier = 1;

        private string flourType;

        private string bakingTechnique;

        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            get => this.flourType;
            set
            {
                if (value != "white" && value != "wholegrain" && value != "White" && value != "Wholegrain")
                {
                    throw new InvalidOperationException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get => this.bakingTechnique;
            set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade" && value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new InvalidOperationException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new InvalidOperationException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double DoughCalories()
        {
            return (2 * this.weight) * FlourModifier() * BakingTechniqueModifier();
        }

        private double FlourModifier()
        {
            if (this.flourType == "white")
            {
                return whiteModifier;
            }

            return wholeGrainModifier;
        }

        private double BakingTechniqueModifier()
        {
            if (this.bakingTechnique == "crispy")
            {
                return crispyModifier;
            }

            else if (this.bakingTechnique == "chewy")
            {
                return chewyModifier;
            }
            return homeMadeModifier;
        }

        
    }
}
