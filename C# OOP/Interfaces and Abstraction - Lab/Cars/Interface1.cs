using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    interface ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        void Start()
        {
            Console.WriteLine("Engine start");
        }

        void Stop()
        {
            Console.WriteLine("Breaaak!");
        }
    }
}
