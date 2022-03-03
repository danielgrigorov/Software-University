using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaciCount = int.Parse(Console.ReadLine());

            int currentPekarOcenka = 0;
            int naiDobriqt = 0;
            string naiDobriqtName = string.Empty;

            for (int i = 0; i < kozunaciCount; i++)
            {
                string pekarName = Console.ReadLine();
                string input = Console.ReadLine();

                while (input != "Stop")
                {
                    int ocenka = int.Parse(input);

                    currentPekarOcenka += ocenka;

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pekarName} has {currentPekarOcenka} points.");

                if (currentPekarOcenka > naiDobriqt)
                {
                    Console.WriteLine($"{pekarName} is the new number 1!");
                    naiDobriqt = currentPekarOcenka;
                    naiDobriqtName = pekarName;
                }
                currentPekarOcenka = 0;


            }
            Console.WriteLine($"{naiDobriqtName} won competition with {naiDobriqt} points!");
        }
    }
}
