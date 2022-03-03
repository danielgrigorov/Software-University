﻿using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] current = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

            
        }
    }
}
