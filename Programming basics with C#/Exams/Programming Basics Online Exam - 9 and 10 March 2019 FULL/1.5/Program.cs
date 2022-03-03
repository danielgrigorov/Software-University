using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int proteinShakeCounter = 0;
            int proteinBarCounter = 0;
            int workout = 0;
            int protein = 0;

            for (int i = 0; i < visitors; i++)
            {
                string action = Console.ReadLine();

                if (action == "Back")
                {
                    backCounter++;
                    workout++;
                }
                else if (action == "Chest")
                {
                    chestCounter++;
                    workout++;
                }
                else if (action == "Legs")
                {
                    legsCounter++;
                    workout++;
                }
                else if (action == "Abs")
                {
                    absCounter++;
                    workout++;
                }
                else if (action == "Protein shake")
                {
                    proteinShakeCounter++;
                    protein++;
                }
                else if (action == "Protein bar")
                {
                    proteinBarCounter++;
                    protein++;
                }
            }
            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{proteinShakeCounter} - protein shake");
            Console.WriteLine($"{proteinBarCounter} - protein bar");
            Console.WriteLine($"{workout * 1.0 / visitors * 100:f2}% - work out");
            Console.WriteLine($"{protein * 1.0 / visitors * 100:f2}% - protein");
        }
    }
}
