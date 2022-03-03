using System;

namespace While_Loop___More_Exercises___01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int detergentTotal = bottles * 750;
            int detergentUsed = 0;
            int currentDetergent = 0;
            int potCounter = 0;
            int cleanDishes = 0;
            int cleanPots = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                currentDetergent = int.Parse(input);
                potCounter++;
                if (potCounter % 3 == 0)
                {
                    detergentUsed += currentDetergent * 15;
                    cleanPots += currentDetergent;
                }
                else
                {
                    detergentUsed += currentDetergent * 5;
                    cleanDishes += currentDetergent;
                }
                if (detergentUsed > detergentTotal)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (detergentTotal >= detergentUsed)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{cleanDishes} dishes and {cleanPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentTotal - detergentUsed} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {detergentUsed - detergentTotal} ml. more necessary!");
            }
        }
    }
}
