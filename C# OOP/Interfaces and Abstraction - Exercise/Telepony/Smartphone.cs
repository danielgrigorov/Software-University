using System;
using System.Collections.Generic;
using System.Text;

namespace Telepony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public void Browsing(string site)
        {
            bool coolSite = true;

            for (int i = 0; i < site.Length; i++)
            {
                if (char.IsDigit(site[i]))
                {
                    Console.WriteLine("Invalid URL!");
                    coolSite = false;
                    break;
                }
            }
            if (coolSite)
            {
                Console.WriteLine($"Browsing: {site}!");
            }
        }

        public void Calling(string number)
        {
            bool coolNumber = true;

            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    Console.WriteLine("Invalid number!");
                    coolNumber = false;
                    break;
                }
            }

            if (coolNumber)
            {
                Console.WriteLine($"Calling... {number}");
            }

        }
    }
}
