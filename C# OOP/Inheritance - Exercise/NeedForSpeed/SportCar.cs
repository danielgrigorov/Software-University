using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsepower, double fuel)
            : base (horsepower, fuel)
        {

        }

        public override double FuelConsumption { get => base.FuelConsumption = 10; }
    }
}
