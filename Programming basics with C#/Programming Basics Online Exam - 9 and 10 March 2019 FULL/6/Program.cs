using System;
using System.ComponentModel.DataAnnotations;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int jelanaVisochina = int.Parse(Console.ReadLine());

            int jumps = 0;
            int failed = 0;

            bool failedNacqlo = false;

            for (int i = 0; i <= 30; i+=5)
            {
                for (int j = 1; j <= 3; j++)
                {
                    int currentTry = int.Parse(Console.ReadLine());
                    if (currentTry > jelanaVisochina - 30 + i)
                    {
                        jumps++;
                        break;
                    }
                    else
                    {
                        failed++;
                        jumps++;
                    }
                    if (failed == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {jelanaVisochina - 30 + i}cm after {jumps} jumps.");
                        failedNacqlo = true;
                        break;
                    }
                }

                if (failedNacqlo == true)
                {
                    break;
                }
                failed = 0;
            }

            if (!failedNacqlo)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {jelanaVisochina}cm after {jumps} jumps.");
            }
        }
    }
}
