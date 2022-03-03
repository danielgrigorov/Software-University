using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;
            string chetnost = "";

            if (operation == "+")
            {
                {
                    result = N1 + N2;
                }
            
            if (result % 2 == 0)
            
                {
                    chetnost = "even";
                }
            
            if (result % 2 != 0)
            
                {
                    chetnost = "odd";
                }
            
            if (N2 != 0)
            
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {chetnost}");
            }
            if (operation == "-")
            {
                {
                    result = N1 - N2;
                }
            
            if (result % 2 == 0)
            
                {
                    chetnost = "even";
                }
            
            if (result % 2 != 0)
            
                {
                    chetnost = "odd";
                }
            
            if (N2 != 0)
            
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {chetnost}");
            }
            if (operation == "*")
            {
                {
                    result = N1 * N2;
                }

                if (result % 2 == 0)

                {
                    chetnost = "even";
                }

                if (result % 2 != 0)

                {
                    chetnost = "odd";
                }

                if (N2 != 0)

                    Console.WriteLine($"{N1} {operation} {N2} = {result} - {chetnost}");
            }
            if (operation == "/")
            {
                {
                    result = N1 / N2;
                }

                if (N2 != 0)

                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
            }
            if (operation == "%")
            {
                {
                    result = (N1 % N2);
                }

                if (N2 != 0)

                    Console.WriteLine($"{N1} % {N2} = {result}");
            }
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
        }
    }
}
