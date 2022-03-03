using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosesPrice = number * 5.00;
            double dahliasPrice = number * 3.80;
            double tulipsPrice = number * 2.80;
            double narcissusPrice = number * 3.00;
            double gladiolusPrice = number * 2.50;
            double final = 0;

            if (typeOfFlowers == "Roses")
            {
                if (number > 80)
                {
                    final = rosesPrice - 0.10 * rosesPrice;
                }
                else
                {
                    final = rosesPrice;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (number > 90)
                {
                    final = dahliasPrice - 0.15 * dahliasPrice;
                }
                else
                {
                    final = dahliasPrice;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (number > 80)
                {
                    final = tulipsPrice - 0.15 * tulipsPrice;
                }
                else
                {
                    final = tulipsPrice;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (number < 120)
                {
                    final = narcissusPrice + 0.15 * narcissusPrice;
                }
                else
                {
                    final = narcissusPrice;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (number < 80)
                {
                    final = gladiolusPrice + 0.20 * gladiolusPrice;
                }
                else
                {
                    final = gladiolusPrice;
                }
            }
            double poveche = budget - final;
            double nedostig = final - budget;
            if (final <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {typeOfFlowers} and {poveche:f2} leva left.");
            }
            else if (final > budget)
            {
                Console.WriteLine($"Not enough money, you need {nedostig:f2} leva more.");
            }
        }
    }
}
