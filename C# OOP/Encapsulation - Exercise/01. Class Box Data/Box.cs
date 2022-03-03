using System;
using System.Collections.Generic;
using System.Text;

namespace P01.BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public void GetSurfaceArea(double l, double w, double h)
        {
            double surfaceArea = 2 * l * h + 2 * w * l + 2 * w * h;
            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        }

        public void GetLateralSurfaceArea(double l, double w, double h)
        {
            double lateralSurfaceArea = 2 * l * h + 2 * w * h;
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        }

        public void GetVolume(double l, double w, double h)
        {
            double volume = l * w * h;
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
