using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.FootballTeamGenerator.Core
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    var cmdArgs = command.Split(';', StringSplitOptions.None).ToArray();

                    string cmdType = cmdArgs[0];

                    if (cmdType == "Team")
                    {
                        string teamName = cmdArgs[1];

                        Team team = new Team(teamName);

                        this.teams.Add(team);
                    }

                    else if (cmdType == "Add")
                    {
                        string teamName = cmdArgs[1];
                        string playerName = cmdArgs[2];

                        if (!this.teams.Any(t => t.Name == teamName))
                        {
                            throw new InvalidOperationException($"Team {teamName} does not exist.");
                        }

                        int endurance = int.Parse(cmdArgs[3]);
                        int sprint = int.Parse(cmdArgs[4]);
                        int dribble = int.Parse(cmdArgs[5]);
                        int passing = int.Parse(cmdArgs[6]);
                        int shooting = int.Parse(cmdArgs[7]);

                        Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

                        Player player = new Player(playerName, stats);

                        Team team = this.teams.First(t => t.Name == teamName);

                        team.AddPlayer(player);
                    }

                    else if (cmdType == "Remove")
                    {
                        string teamName = cmdArgs[1];
                        string playerName = cmdArgs[2];

                        if (!this.teams.Any(t => t.Name == teamName))
                        {
                            throw new InvalidOperationException($"Team {teamName} does not exist.");
                        }

                        Team team = this.teams.First(t => t.Name == teamName);

                        team.RemovePlayer(playerName);
                    }

                    else if (cmdType == "Rating")
                    {
                        string teamName = cmdArgs[1];

                        if (!this.teams.Any(t => t.Name == teamName))
                        {
                            throw new InvalidOperationException($"Team {teamName} does not exist.");
                        }

                        Team team = this.teams.First(t => t.Name == teamName);

                        Console.WriteLine(team);
                    }
                }

                catch (Exception ioe)
                {
                    Console.WriteLine(ioe.Message);
                }



            }
        }
    }
}

