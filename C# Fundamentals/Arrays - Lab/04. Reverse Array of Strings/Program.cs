using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[array.Length - i - 1] + " ");
            }
        }
    }
}
