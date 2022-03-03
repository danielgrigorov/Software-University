using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var list = new List<int>();

            bool success = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i %input[j] == 0)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    list.Add(i);
                }
                else
                {
                    success = false;
                }

            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
