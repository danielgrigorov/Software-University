using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPricePerNight = 0;
            double apartmentPricePerNight = 0;
            double discount = 0;

            if (month == "May" || month == "October")
            {
                studioPricePerNight = 50;
                apartmentPricePerNight = 65;
            }
            else if (month == "June" || month == "September")
            {
                studioPricePerNight = 75.20;
                apartmentPricePerNight = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studioPricePerNight = 76;
                apartmentPricePerNight = 77;
            }
            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <=14)
                {
                    studioPricePerNight = studioPricePerNight - 0.05 * studioPricePerNight;
                }
                else if (nights > 14)
                {
                    studioPricePerNight = studioPricePerNight - 0.3 * studioPricePerNight;
                }
            }
            if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studioPricePerNight = studioPricePerNight - 0.2 * studioPricePerNight;
                }
            }
            if (nights > 14)
            {
                apartmentPricePerNight = apartmentPricePerNight - 0.1 * apartmentPricePerNight;
            }
            double studioOverall = (studioPricePerNight * nights) - discount;
            double apartmentOverall = (apartmentPricePerNight * nights) - discount;

            Console.WriteLine($"Apartment: {apartmentOverall:f2} lv.");
            Console.WriteLine($"Studio: {studioOverall:f2} lv.");
        }
    }
}
