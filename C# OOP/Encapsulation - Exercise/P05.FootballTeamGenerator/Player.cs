using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.FootballTeamGenerator
{
    public class Player
    {
        private string name;

        private Stats stats;

        private int skillLevel;


        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name 
        { 
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("A name should not be empty.");
                }
                this.name = value;
            } 
        }

        public Stats Stats { get; set; }

        public double OverallSkill => this.Stats.AverageStats;

        

    }
}
