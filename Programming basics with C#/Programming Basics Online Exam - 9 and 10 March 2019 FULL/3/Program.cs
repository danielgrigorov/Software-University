using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string ured = Console.ReadLine();

            double ocenka = 0;

            if (country == "Russia")
            {
                if (ured == "ribbon")
                {
                    ocenka = 9.1 + 9.4;
                }
                else if (ured == "hoop")
                {
                    ocenka = 9.3 + 9.8;
                }
                else if (ured == "rope")
                {
                    ocenka = 9.6 + 9.0;
                }
            }
            else if (country == "Bulgaria")
            {
                if (ured == "ribbon")
                {
                    ocenka = 9.6 + 9.4;
                }
                else if (ured == "hoop")
                {
                    ocenka = 9.55 + 9.75;
                }
                else if (ured == "rope")
                {
                    ocenka = 9.5 + 9.4;
                }
            }
            else if (country == "Italy")
            {
                if (ured == "ribbon")
                {
                    ocenka = 9.2 + 9.5;
                }
                else if (ured == "hoop")
                {
                    ocenka = 9.45 + 9.35;
                }
                else if (ured == "rope")
                {
                    ocenka = 9.7 + 9.15;
                }
            }

            double razlika = 20 - ocenka;
            Console.WriteLine($"The team of {country} get {ocenka:f3} on {ured}.");
            Console.WriteLine($"{razlika/20 * 100:f2}%");
        }
    }
}
