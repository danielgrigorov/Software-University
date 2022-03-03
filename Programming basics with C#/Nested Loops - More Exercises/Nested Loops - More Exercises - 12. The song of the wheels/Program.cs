using System;

namespace Nested_Loops___More_Exercises___12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            bool noMagicNumber = false;
            string pass = string.Empty;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <=9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a*b + c*d == M && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;
                                if (counter == 4)
                                {
                                    pass = string.Concat(a,b,c,d);
                                    noMagicNumber = true;
                                }
                            }
                        }
                    }
                }
            }
            if (noMagicNumber == false)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {pass}");
            }
        }
    }
}
