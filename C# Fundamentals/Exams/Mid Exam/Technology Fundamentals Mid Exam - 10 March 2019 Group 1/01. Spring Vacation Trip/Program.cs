using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPerKm = double.Parse(Console.ReadLine());
            double foodPerPersonPerDay = double.Parse(Console.ReadLine());
            double hotelPerPersonPerDay = double.Parse(Console.ReadLine());

            if (people > 10)
            {
                hotelPerPersonPerDay *= 0.75;
            }

            double sum = days * people * (foodPerPersonPerDay + hotelPerPersonPerDay);


            for (int i = 1; i <= days; i++)
            {
                double distance = double.Parse(Console.ReadLine());

                sum += distance * fuelPerKm;

                if (i %3 == 0 || i %5 == 0)
                {
                    sum += sum * 0.4;
                }

                if (i %7 == 0)
                {
                    sum -= sum / people;
                }

                if (sum > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(sum - budget):f2}$ more.");
                    return;
                }
            }
                Console.WriteLine($"You have reached the destination. You have {(budget-sum):f2}$ budget left.");
        }
    }
}
