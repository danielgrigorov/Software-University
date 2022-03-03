using System;
using System.Collections.Generic;
using System.Text;

namespace Telepony
{
    public class StationaryPhone : ICallable
    {
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
                Console.WriteLine($"Dialing... {number}");
            }
        }
    }
}
