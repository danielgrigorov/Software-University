using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                names.Add(current);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
