using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 16; i < n; i++)
            {
                int sum = 0;
                int odd = 0;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    char pacha =  i.ToString()[j];
                    string hui = pacha.ToString();
                    int kur = int.Parse(hui);
                    sum += kur;
                }

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    char pacha = i.ToString()[j];
                    string hui = pacha.ToString();
                    int kur = int.Parse(hui);

                    if (kur %2 == 1)
                    {
                        odd++;
                        break;
                    }
                }

                if (sum %8 == 0 && odd == 1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
