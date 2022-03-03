using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.8;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.6;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.5;
                }
            }
            if (type == "Students" && amount >= 30)
            {
                price *= 0.85;
            }
            if (type == "Business" && amount >= 100)
            {
                amount -= 10;
            }
            if (type == "Regular" && amount >= 10 && amount <= 20)
            {
                price *= 0.95;
            }
            Console.WriteLine($"Total price: {price*amount:f2}");
        }
    }
}
