using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s*,\s*";

            string[] tickets = Regex.Split(Console.ReadLine(), pattern).ToArray();

            if (tickets[0] == "")
            {
                return;
            }

            if (tickets.Length > 0)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i].Length != 20)
                    {
                        Console.WriteLine("invalid ticket");
                    }
                    else
                    {
                        string currentTicket = tickets[i];
                        string firstHalf = string.Empty;
                        string secondHalf = string.Empty;

                        for (int j = 0; j < currentTicket.Length / 2; j++)
                        {
                            firstHalf += currentTicket[j];
                        }
                        for (int j = 10; j < currentTicket.Length; j++)
                        {
                            secondHalf += currentTicket[j];
                        }

                        string pattern2 = @"[@]{6,10}|[$]{6,10}|[#]{6,10}|[\^]{6,10}";

                        if (Regex.IsMatch(firstHalf, pattern2))
                        {
                            MatchCollection collection = Regex.Matches(firstHalf, pattern2);

                            string winningSymbolLaino = string.Empty;
                            string winningSymbol = string.Empty;
                            int counter = 0;

                            foreach (Match item in collection)
                            {
                                winningSymbolLaino = item.Value;
                                counter = winningSymbolLaino.Length;
                                winningSymbol = winningSymbolLaino[0].ToString();
                            }

                            string pattern3 = $@"[\{winningSymbol}]{{6,{counter}}}";

                            if (Regex.IsMatch(secondHalf, pattern3))
                            {
                                MatchCollection collection2 = Regex.Matches(secondHalf, pattern3);

                                int counter2 = 0;

                                foreach (Match item in collection2)
                                {
                                    string pacul = item.Value;
                                    counter2 = pacul.Length;
                                }

                                if (Math.Min(counter,counter2) >= 6 && Math.Min(counter, counter2) <= 9)
                                {
                                    Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(counter,counter2)}{winningSymbol}");
                                }
                                else if (counter == 10)
                                {
                                    Console.WriteLine($"ticket \"{currentTicket}\" - 10{winningSymbol} Jackpot!");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                        }
                    }
                }
            }
        }
    }
}
