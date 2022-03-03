using System;

namespace While_Loop___More_Exercises___03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialCount = 0;
            int cCount = 0;
            int oCount = 0;
            int nCount = 0;
            string word = string.Empty;

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "c")
                {
                    if (specialCount %3 != 0)
                    {
                        specialCount++;
                    }
                    else
                    {
                        Console.Write($"{word} ");
                    }
                    if (cCount %2 != 0)
                    {
                        cCount++;
                    }
                    else
                    {
                        word = word + input;
                    }
                }

                if (input == "o")
                {
                    if (specialCount % 3 != 0)
                    {
                        specialCount++;
                    }
                    else
                    {
                        Console.Write($"{word} ");
                    }
                    if (oCount % 2 != 0)
                    {
                        oCount++;
                    }
                    else
                    {
                        word = word + input;
                    }
                }

                if (input == "n")
                {
                    if (specialCount % 3 != 0)
                    {
                        specialCount++;
                    }
                    else
                    {
                        Console.Write($"{word} ");
                    }
                    if (nCount % 2 != 0)
                    {
                        nCount++;
                    }
                    else
                    {
                        word = word + input;
                    }
                }
                else
                {
                    word = word + input;
                }
                input = Console.ReadLine();
            }
        }
    }
}
