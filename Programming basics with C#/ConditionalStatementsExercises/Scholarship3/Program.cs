using System;

namespace Scholarship3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Income = double.Parse(Console.ReadLine());
            double Grades = double.Parse(Console.ReadLine());
            double MinimumWage = double.Parse(Console.ReadLine());

            bool EligibleForSocialScholarship = false;
            if (Income < MinimumWage && Grades > 4.5) { EligibleForSocialScholarship = true; }

            bool EligibleForGradesScholarship = false;
            if (Grades >= 5.50) { EligibleForGradesScholarship = true; }

            double AmountOfSocialScholarship = Math.Floor(0.35 * MinimumWage);
            double AmountOfMarksScholarship = Math.Floor(25 * Grades);

            if (EligibleForGradesScholarship == false && EligibleForSocialScholarship == false)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (EligibleForSocialScholarship == true && EligibleForGradesScholarship == false)
            {
                Console.WriteLine($"You get a Social scholarship {AmountOfSocialScholarship} BGN");
            }
            else if (EligibleForSocialScholarship == false && EligibleForGradesScholarship == true)
            {
                Console.WriteLine($"You get a scholarship for excellent results {AmountOfMarksScholarship} BGN");
            }
            else if (EligibleForSocialScholarship == true && EligibleForGradesScholarship == true)
            {
                if (AmountOfSocialScholarship > AmountOfMarksScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {AmountOfSocialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {AmountOfMarksScholarship} BGN");
                }
            }
        }
    }
}
