using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothesPerStatist = clothes * statists;

            if (statists >150)
            {
                clothesPerStatist = clothesPerStatist - 0.10 * clothesPerStatist;
            }
            double expenses = clothesPerStatist + decor;
            double difference1 = budget - expenses;

            if (budget>=expenses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference1:f2} leva left.");
            }
            double difference2 = expenses - budget;

            if (expenses>budget)
            {
                Console.WriteLine("Not enough money!" );
                Console.WriteLine($"Wingard needs {difference2:f2} leva more.");
            }
        }
    }
}
