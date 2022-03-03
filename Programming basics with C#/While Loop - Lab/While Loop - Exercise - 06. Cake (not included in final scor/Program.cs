using System;

namespace While_Loop___Exercise___06._Cake__not_included_in_final_scor
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int area = l * w;
            int areaAte = 0;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int piece = int.Parse(input);
                areaAte += piece;
                if (areaAte > area)
                {
                    Console.WriteLine($"No more cake left! You need {areaAte - area} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{area - areaAte} pieces are left.");
            }
        }
    }
}
