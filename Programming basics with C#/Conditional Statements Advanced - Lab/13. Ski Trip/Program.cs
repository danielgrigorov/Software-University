using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;
            
            double discount = 0;
            double discount2 = 0;

            if (room == "room for one person")
            {
                price = 18;
            }

            else if (room == "apartment")
            {
                if (days < 10)
                {
                    price = 25 - 0.3 * 25;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = 25 - 0.35 * 25;
                }
                else if (days > 15)
                {
                    price = 25 - 0.5 * 25;
                }

            }
            else if (room == "president apartment")
                {
                    if (days < 10)
                    {
                        price = 35 - 0.1 * 35;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = 35 - 0.15 * 35;
                    }
                    else if (days > 15)
                    {
                        price = 35 - 0.2 * 35;
                    }
                }
            double priceTotal = (days - 1) * price;

            if (feedback == "positive")
            {
                priceTotal = priceTotal + 0.25 * priceTotal;
            }
            else if (feedback == "negative")
            {
                priceTotal = priceTotal - 0.10 * priceTotal;
            }
            Console.WriteLine($"{priceTotal:f2}");
        }
    }
}
