using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "course start")
                {
                    break;
                }

                string[] token = command.Split(":");

                string function = token[0];

                string lessonTitle = token[1];

                if (function == "Add")
                {
                    if (list.Contains(lessonTitle))
                    {

                    }
                    else
                    {
                        list.Add(lessonTitle);
                    }
                }
                else if (function == "Insert")
                {
                    if (list.Contains(lessonTitle))
                    {

                    }
                    else
                    {
                        list.Insert(int.Parse(token[2]), lessonTitle);
                    }
                }
                else if (function == "Remove")
                {
                    if (list.Contains(lessonTitle))
                    {
                        list.Remove(lessonTitle);
                    }
                    if (list.Contains($"{lessonTitle}-Exercise"))
                    {
                        list.Remove($"{lessonTitle}-Exercise");
                    }
                }
                else if (function == "Swap")
                {
                    if (list.Contains(lessonTitle))
                    {
                        if (list.Contains(token[2]))
                        {
         
                            int firstIndex = list.IndexOf(lessonTitle); 
                            int secondIndex = list.IndexOf(token[2]);
                            list[firstIndex] = token[2];
                            list[secondIndex] = lessonTitle;

                            if (list.Contains($"{lessonTitle}-Exercise"))
                            {
                                list.Insert(secondIndex + 2, $"{lessonTitle}-Exercise");
                            }

                            if (list.Contains($"{token[2]}-Exercise"))
                            {
                                list.Insert(firstIndex + 1, $"{token[2]}-Exercise");
                                list.RemoveAt(secondIndex + 2);
                            }
                        }
                    }
                }
                else if (function == "Exercise")
                {
                    if (list.Contains(lessonTitle))
                    {
                        if (list.Contains($"{lessonTitle}-Exercise"))
                        {

                        }
                        else
                        {
                            int lessonIndex = list.IndexOf(lessonTitle);
                            list.Insert(lessonIndex + 1, $"{lessonTitle}-Exercise");
                        }
                       
                    }
                    else
                    {
                        list.Add(lessonTitle);
                        list.Add($"{lessonTitle}-Exercise");
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }
    }
}
