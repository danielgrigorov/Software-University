using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int points = 0;
            int startIndex = 0;
            int length = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Game over")
                {
                    break;
                }

                string[] token = command.Split("@", StringSplitOptions.RemoveEmptyEntries);

                string action = token[0];

                if (token.Length > 1)
                {
                    startIndex = int.Parse(token[1]);
                    length = int.Parse(token[2]);
                }

                if (action == "Shoot Left" && startIndex >= 0 && startIndex <= targets.Count - 1)
                {
                    if (startIndex > length)
                    {
                        if (targets[startIndex - length] >= 5)
                        {
                            targets[startIndex - length] = targets[startIndex - length] - 5;
                            points += 5;
                        }
                        else
                        {
                            points += targets[startIndex - length];
                            targets[startIndex - length] = 0;
                        }
                        
                        

                    }
                    else
                    {
                        if (length <= targets.Count)
                        {
                            int currentIndex = startIndex + (targets.Count - length);
                            if (targets[currentIndex] >= 5)
                            {
                                targets[currentIndex] -= 5;
                                points += 5;
                            }

                            else
                            {
                                points += targets[currentIndex];
                                targets[currentIndex] = 0;
                            }

                            // 34|56|78|92|87|65|73|93|83|64 
                        }

                        if (length > targets.Count)
                        {
                            int currentIndex = startIndex + (targets.Count - (length % targets.Count));

                            if (currentIndex > targets.Count - 1)
                            {
                                currentIndex = currentIndex % targets.Count;
                            }
                            if (targets[currentIndex] >= 5)
                            {
                                targets[currentIndex] -= 5;
                                points += 5;
                            }

                            else
                            {
                                points += targets[currentIndex];
                                targets[currentIndex] = 0;
                            }


                        }
                    }
                }

                else if (action == "Shoot Right" && startIndex >= 0 && startIndex <= targets.Count - 1)
                {
                    if (startIndex + length <= targets.Count)
                    {
                        if (targets[startIndex + length] >= 5)
                        {
                            targets[startIndex + length] = targets[startIndex + length] - 5;
                            points += 5;
                        }

                        else
                        {
                            points += targets[startIndex + length];
                            targets[startIndex + length] = 0;
                        }

                    }

                    else
                    {
                        if (length <= targets.Count)
                        {
                            int currentIndex = startIndex + (length - targets.Count);

                            if (targets[currentIndex] >= 5)
                            {
                                targets[currentIndex] -= 5;
                                points += 5;
                            }

                            else
                            {
                                points += targets[currentIndex];
                                targets[currentIndex] = 0;
                            }
                            


                            // 34|56|78|92|87|65|73|93|83|64 
                        }

                        if (length > targets.Count)
                        {
                            int currentIndex = startIndex + ((length % targets.Count) - targets.Count);

                            if (currentIndex > targets.Count - 1)
                            {
                                currentIndex = currentIndex % targets.Count;
                            }
                            else if (currentIndex < 0)
                            {
                                currentIndex = currentIndex + targets.Count;
                            }

                            if (targets[currentIndex] >= 5)
                            {
                                targets[currentIndex] -= 5;
                                points += 5;
                            }

                            else
                            {
                                points += targets[currentIndex];
                                targets[currentIndex] = 0;
                            }
                            

                        }
                    }
                }

                else if (action == "Reverse")
                {
                    targets.Reverse();
                }

            }
            Console.WriteLine(string.Join (" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
//400 300 200 100 500
//500 100 200 300 400
// 0   1   2   3   4