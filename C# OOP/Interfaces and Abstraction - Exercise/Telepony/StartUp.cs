using System;
using System.Linq;

namespace Telepony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbersToCall = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < phoneNumbersToCall.Length; i++)
            {
                Smartphone smartphone = new Smartphone();
                StationaryPhone stationaryPhone = new StationaryPhone();

                string number = phoneNumbersToCall[i];

                if (number.Length == 7)
                {
                    stationaryPhone.Calling(number);
                }
                else if (number.Length == 10)
                {
                    smartphone.Calling(number);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            var webSitesToVisit = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < webSitesToVisit.Length; i++)
            {
                Smartphone smartphone = new Smartphone();

                string site = webSitesToVisit[i];

                smartphone.Browsing(site);
            }
        }
    }
}
