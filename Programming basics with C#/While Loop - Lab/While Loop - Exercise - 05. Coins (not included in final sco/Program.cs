using System;

namespace While_Loop___Exercise___05._Coins__not_included_in_final_sco
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int counter = 0;

            while (change > 0.0)
            {

                if (change - 2 >= 0)
                {
                    change = change - 2.00;
                    change = Math.Round(change, 2);
                    counter++;
                }
                else if (change - 1 >= 0)
                {
                    change -= 1;
                    change = Math.Round(change, 2);

                    counter++;
                }
                else if (change - 0.50 >= 0)
                {
                    change -= 0.50;
                    change = Math.Round(change, 2);

                    counter++;
                }
                else if(change - 0.20 >= 0)
                {
                    change -= 0.20;
                    change = Math.Round(change, 2);

                    counter++;
                }
                else if (change - 0.10 >= 0)
                {
                    change -= 0.10;
                    change = Math.Round(change, 2);

                    counter++;
                }
                else if (change - 0.05 >= 0)
                {
                    change -= 0.05;
                    change = Math.Round(change, 2);

                    counter++;
                }
                else if (change - 0.02 >= 0)
                {
                    change -= 0.02;
                    change = Math.Round(change, 2);

                    counter++;
                }
                else if (change - 0.01 >= 0)
                {
                    change -= 0.01;
                    change = Math.Round(change, 2);

                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
