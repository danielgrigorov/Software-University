using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck
    {
        private const double fuelConsumptionIncrease = 1.6;


        private double fuelQuantity;

        private double fuelConsumption;

        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQunatity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQunatity { get; set; }
        public double FuelConsumption { get; set; }

        public bool CanTravel(double distance)
        {
            if (FuelQunatity >= distance * (FuelConsumption + fuelConsumptionIncrease))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Drive(double distance)
        {
            this.FuelQunatity -= distance * (FuelConsumption + fuelConsumptionIncrease);
        }

        public void Refuel(double liters)
        {
            FuelQunatity += 0.95 * liters;
        }

    }
}
