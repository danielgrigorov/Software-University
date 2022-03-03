using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public double DefaultFuelConsumption { get; set; } 

        public virtual double FuelConsumption { get; set; } = 1.25;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}
