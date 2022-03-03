using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isDifferent = false;

            List<int> numbers2 = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers2.Add(numbers[i]);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                    isDifferent = true;
                }
                else if (tokens[0] == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                    isDifferent = true;

                }
                else if (tokens[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                    isDifferent = true;

                }
                else if (tokens[0] == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                    isDifferent = true;

                }
                else if (tokens[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(tokens[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (tokens[0] == "PrintEven")
                {
                    List<int> newList = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            newList.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join (" ", newList));
                }
                else if (tokens[0] == "PrintOdd")
                {
                    List<int> newList2 = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            newList2.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", newList2));

                }
                else if (tokens[0] == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine($"{sum}");
                }
                else if (tokens[0] == "Filter")
                {
                    List<int> newList3 = new List<int>();

                    if (tokens[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(tokens[2]))
                            {
                                newList3.Add(numbers[i]);

                            }
                        }
                        Console.WriteLine(string.Join(" ", newList3));

                    }
                    else if (tokens[1] == ">=")
                    {
                        List<int> newList4 = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(tokens[2]))
                            {
                                newList4.Add(numbers[i]);

                            }
                        }
                        Console.WriteLine(string.Join(" ", newList4));

                    }
                    else if (tokens[1] == "<")
                    {
                        List<int> newList5 = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(tokens[2]))
                            {
                                newList5.Add(numbers[i]);

                            }
                        }
                        Console.WriteLine(string.Join(" ", newList5));

                    }
                    else if (tokens[1] == "<=")
                    {
                        List<int> newList6 = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(tokens[2]))
                            {
                                newList6.Add(numbers[i]);

                            }
                        }
                        Console.WriteLine(string.Join(" ", newList6));

                    }
                }
            }

            if (isDifferent)
            {

            Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
