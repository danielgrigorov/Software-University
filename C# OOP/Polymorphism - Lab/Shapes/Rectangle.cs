using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;

        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height 
        { 
            get => this.height;
            set 
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Height cannot be 0 or negative");
                }
                this.height = value;
            } 
        }

        public double Width 
        { 
            get => this.width;
            set 
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Width cannot be 0 or negative");
                }
                this.width = value;
            }
        }

        public override double CalculateArea()
        {
            return this.width * this.height;
        }

        public override double CalculatePerimeter()
        {
            return 2*(this.width + this.height);
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
