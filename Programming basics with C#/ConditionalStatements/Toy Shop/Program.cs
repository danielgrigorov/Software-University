using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double puzzlesPrice = 2.60;
            double dollsPrice = 3.00;
            double bearsPrice = 4.10;
            double minionsPrice = 8.20;
            double trucksPrice = 2.00;
            double totalPrice = puzzles * puzzlesPrice + dolls * dollsPrice + bears * bearsPrice + minions * minionsPrice + trucks * trucksPrice;
            double totalQuantity = puzzles + dolls + bears + minions + trucks;

            if (totalQuantity >= 50)
            {
                totalPrice = totalPrice - 0.25 * totalPrice;
            }

            double totalPriceAfterRent = totalPrice - 0.10 * totalPrice;
            double final = totalPriceAfterRent - tripPrice;
            double final2 = tripPrice - totalPriceAfterRent;

                if (tripPrice <= totalPriceAfterRent)
            {
                Console.WriteLine($"Yes! {final:f2} lv left.");
            }

                else
            {
                Console.WriteLine($"Not enough money! {final2:f2} lv needed.");
            }
           




            }
        }
    }
