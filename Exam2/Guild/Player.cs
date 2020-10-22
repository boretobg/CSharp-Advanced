using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank = "Trial";
        public string Description = "n/a";

        public Player(string name, string playerClass)
        {
            this.Name = name;
            this.Class = playerClass;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Player {Name}: {Class}");
            stringBuilder.AppendLine($"Rank: {Rank}");
            stringBuilder.Append($"Description: {Description}");
            return stringBuilder.ToString();
        }
    }
}
