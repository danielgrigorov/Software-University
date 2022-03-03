using System;

namespace Conditional_Statements___More_Exercises___01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double firstPipe = P1 * H;
            double secondPipe = P2 * H;

            double firstPipePercentage = firstPipe / (firstPipe + secondPipe) * 100;
            double secondPipePercentage = secondPipe / (firstPipe + secondPipe) * 100;
            double totalPercentage = (firstPipe + secondPipe) / V * 100;

            if (firstPipe + secondPipe <= V)
            {
                Console.WriteLine($"The pool is {totalPercentage:f2}% full. Pipe 1: {firstPipePercentage:f2}%. Pipe 2: {secondPipePercentage:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {H} hours the pool overflows with {firstPipe + secondPipe - V} liters.");
            }
        }
    }
}
