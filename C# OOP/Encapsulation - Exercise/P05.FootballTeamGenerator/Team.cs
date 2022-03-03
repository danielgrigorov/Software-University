using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.FootballTeamGenerator
{
    public class Team
    {
        private string name;

        private int rating;

        private List<Player> players;


        public Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            :this()
        {
            this.Name = name;
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

        public int Rating
        {
            get
            {
                if (this.players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(this.players.Sum(p => p.OverallSkill / this.players.Count));
            }
        }

        public IReadOnlyCollection<Player> Players => this.players.AsReadOnly();

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == name);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException($"Player {name} is not in {this.Name} team.");
            }

            this.players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
