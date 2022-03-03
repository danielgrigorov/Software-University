using System;

namespace _10._Poke_Mon__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int newN = n;

            int counter = 0;

            while (newN >= m)
            {

                newN -= m;
                counter++;

                if (newN == n * 0.5 && y != 0)
                {
                    newN /= y;
                }

                   
            }
            Console.WriteLine(newN);
            Console.WriteLine(counter);
        }
    }
}
