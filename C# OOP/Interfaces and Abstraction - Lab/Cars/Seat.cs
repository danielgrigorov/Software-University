using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;

        private string color;

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }

        public string Color { get; set; }



        public void Start() { }

        public void Stop()
        {
        }

        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}";
        }
    }
}
