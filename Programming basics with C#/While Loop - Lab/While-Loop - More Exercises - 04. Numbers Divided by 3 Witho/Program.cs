using System;

namespace While_Loop___More_Exercises___04._Numbers_Divided_by_3_Witho
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i %3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
