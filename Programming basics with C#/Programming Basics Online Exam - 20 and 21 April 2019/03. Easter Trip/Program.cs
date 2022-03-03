using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int pricePerNight = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    pricePerNight = 30;
                }
                else if (dates == "24-27")
                {
                    pricePerNight = 35;
                }
                else
                {
                    pricePerNight = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    pricePerNight = 28;
                }
                else if (dates == "24-27")
                {
                    pricePerNight = 32;
                }
                else
                {
                    pricePerNight = 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    pricePerNight = 32;
                }
                else if (dates == "24-27")
                {
                    pricePerNight = 37;
                }
                else
                {
                    pricePerNight = 43;
                }
            }
            int totalPrice = pricePerNight * nights;

            Console.WriteLine($"Easter trip to {destination} : {totalPrice:F2} leva.");
        }
    }
}
