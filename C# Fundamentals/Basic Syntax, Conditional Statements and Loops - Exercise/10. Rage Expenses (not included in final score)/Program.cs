using System;

namespace _10._Rage_Expenses__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCounter = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = lostGamesCounter / 2;
            int mouseCount = lostGamesCounter / 3;
            int keyboardCount = lostGamesCounter / 6;
            int displayCount = lostGamesCounter / 12;

            double totalExpenses = headsetPrice * headsetCount + mousePrice * mouseCount + keyboardPrice * keyboardCount + displayPrice * displayCount;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
