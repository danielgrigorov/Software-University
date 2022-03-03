using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name, string playerClass)
        {
            this.Name = name;
            this.Class = playerClass;
        }

        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; } = "Trial";

        public string Description { get; set; } = "n/a";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {this.Name}: {this.Class}");
            sb.AppendLine($"Rank: {this.Rank}");
            sb.AppendLine($"Description: {this.Description}");

            return sb.ToString().TrimEnd();
        }

    }
}
