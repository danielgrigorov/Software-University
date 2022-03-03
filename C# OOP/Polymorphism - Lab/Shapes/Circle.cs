using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        { 
            get => this.radius;
            set 
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Radius cannot be 0 or negative");
                }
                this.radius = value;
            } 
        }

        public override double CalculateArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
