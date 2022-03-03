using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfDays = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int amountOfDoctors = 7;
            int judgementDay = 1;

            for (int i = 1; i <= amountOfDays; i++)
            {
                if (judgementDay % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        amountOfDoctors++;
                    }
                }
                int currentPatients = int.Parse(Console.ReadLine());

                if (currentPatients <= amountOfDoctors)
                {
                    treatedPatients += currentPatients;
                }
                else if (currentPatients > amountOfDoctors)
                {
                    treatedPatients += amountOfDoctors;
                    untreatedPatients += currentPatients - amountOfDoctors;
                }
               
                judgementDay++;
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
