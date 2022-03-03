using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Car
{
   public class Car2
    {
        private int year;

        public Car2()
            :this("VW", "Golf",2025,200,10)
        {

        }

        public Car2(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car2(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year 
        {
            get { return this.year; }
            set
            {
                if (value < 1989)
                {
                    throw new InvalidOperationException("Year cannot be less than 1989");
                }
                this.year = value;
            }
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; }

        public void Drive(double distance)
        {
            var canContinue = this.FuelQuantity - (distance*this.FuelConsumption) >=0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                throw new InvalidOperationException("Not enough fuel.");
            }
        }


    }
}
