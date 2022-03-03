﻿using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models
{
    public abstract class Car : ICar
    {
        private int minHorsePower;

        private int maxHorsePower;

        private string model;

        private int horsePower;

        private double cubicCentimeters;

       

        protected Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            this.minHorsePower = minHorsePower;
            this.maxHorsePower = maxHorsePower;
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model 
        { 
            get => this.model;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }
                this.model = value;
            } 
        }

        public int HorsePower 
        {
            get
            {
                return this.horsePower;
            }
            private set
            {
                if (value >= this.minHorsePower && value <= this.maxHorsePower)
                {
                    this.horsePower = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
            }
        }

        public double CubicCentimeters { get; }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }
    }
}
