using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public int Age 
        { 
            get=> this.age; 
            set=> this.age = value; 
        }

        public double Pressure
        {
            get => this.pressure;
            set => this.pressure = value;
        }
    }
}
