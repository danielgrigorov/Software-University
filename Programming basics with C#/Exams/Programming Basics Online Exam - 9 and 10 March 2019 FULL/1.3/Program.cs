using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsAmount = int.Parse(Console.ReadLine());
            char picWithTheTrophy = char.Parse(Console.ReadLine());

            double price = 0;

            if (stage == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    price = 55.50;
                }
                else if (ticketType == "Premium")
                {
                    price = 105.20;
                }
                else if (ticketType == "VIP")
                {
                    price = 118.90;
                }
            }
            else if (stage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    price = 75.88;
                }
                else if (ticketType == "Premium")
                {
                    price = 125.22;
                }
                else if (ticketType == "VIP")
                {
                    price = 300.40;
                }
            }
            else if (stage == "Final")
            {
                if (ticketType == "Standard")
                {
                    price = 110.10;
                }
                else if (ticketType == "Premium")
                {
                    price = 160.66;
                }
                else if (ticketType == "VIP")
                {
                    price = 400;
                }
            }

            double totalTicketsPriceClean = price * ticketsAmount;

            

            if (totalTicketsPriceClean > 4000)
            {
                totalTicketsPriceClean *= 0.75;
            }
            else if (totalTicketsPriceClean > 2500)
            {
                totalTicketsPriceClean *= 0.9;
                if (picWithTheTrophy == 'Y')
                {
                    totalTicketsPriceClean += ticketsAmount * 40;
                }
            }
            else if (totalTicketsPriceClean <= 2500 && picWithTheTrophy == 'Y')
            {
                totalTicketsPriceClean += ticketsAmount * 40;
            }
            Console.WriteLine($"{totalTicketsPriceClean:f2}");

        }
    }
}
