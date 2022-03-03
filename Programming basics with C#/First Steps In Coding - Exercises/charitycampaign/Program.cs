using System;

namespace charitycampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sugarGuys = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());
            double priceOfCakes = 45.00;
            double priceOfWaffles = 5.80;
            double priceOfPancakes = 3.20;
            double sumOfCakes = numberOfCakes * priceOfCakes;
            double sumOfWaffles = numberOfWaffles * priceOfWaffles;
            double sumOfPancakes = numberOfPancakes * priceOfPancakes;
            double sumForDay = (sumOfCakes + sumOfPancakes + sumOfWaffles) * sugarGuys;
            double sumForTheWholeCampaign = sumForDay * days;
            double end = sumForTheWholeCampaign - sumForTheWholeCampaign / 8;
            Console.WriteLine($"{end:f2}");
               

                


        }
    }
}
