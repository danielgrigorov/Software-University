using System;

namespace Nested_Loops___Lab___07._Cinema_Tickets__not_included_in_fin
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double student = 0;
            double standard = 0;
            double kid = 0;
            double totalTickets = 0;
            double studentOverall = 0;
            double standardOverall = 0;
            double kidOverall = 0;

            while (movieName != "Finish")
            {
                double freeSpots = double.Parse(Console.ReadLine());
                for (int i = 1; i <= freeSpots; i++)
                {
                    string typeOfTicket = Console.ReadLine();
                    if (typeOfTicket == "student")
                    {
                        student++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standard++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kid++;
                    }
                    if (typeOfTicket == "End")
                    {
                        break;
                    }
                    totalTickets++;
                }
                Console.WriteLine($"{movieName} - {(standard + student + kid) / freeSpots * 100:f2}% full.");
                studentOverall += student;
                standardOverall += standard;
                kidOverall += kid;
                standard = 0;
                student = 0;
                kid = 0;
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentOverall/totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardOverall/totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidOverall/totalTickets * 100:f2}% kids tickets.");
        }
    }
}
