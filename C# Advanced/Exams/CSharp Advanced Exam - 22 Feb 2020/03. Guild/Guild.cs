using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }

        public List<Player> Roster
        {
            get => this.roster;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (this.roster.Count + 1 <= this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            var player = this.roster.FirstOrDefault(x => x.Name == name);

            if (player == null)
            {
                return false;
            }

            this.roster.Remove(player);
            return true;
        }

        public void PromotePlayer(string name)
        {
            var player = this.roster.FirstOrDefault(x => x.Name == name);

            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            var player = this.roster.FirstOrDefault(x => x.Name == name);

            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string playerClass)
        {
            var deletedPlayersByClass = this.roster.Where(x => x.Class == playerClass).ToArray();

            this.roster.RemoveAll(x=>x.Class == playerClass);

            return deletedPlayersByClass;
        }

        public int Count => this.roster.Count();

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in roster)
            {
                sb.AppendLine($"{player}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
