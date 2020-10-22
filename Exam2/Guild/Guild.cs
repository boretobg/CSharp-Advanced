using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return roster.Count; } }

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player toRemove = roster.FirstOrDefault(c => c.Name == name);
            if (toRemove != null)
            {
                roster.Remove(toRemove);
                return true;
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            Player toPromote = roster.FirstOrDefault(p => p.Name == name);
            if (toPromote != null)
            {
                if (toPromote.Rank != "Member")
                {
                    toPromote.Rank = "Member";
                }
            }
        }
        public void DemotePlayer(string name)
        {
            Player toDemote = roster.FirstOrDefault(p => p.Name == name);
            if (toDemote != null)
            {
                if (toDemote.Rank != "Trial")
                {
                    toDemote.Rank = "Trial";
                }
            }
        }
        public Player[] KickPlayersByClass(string playerClass)
        {
            var list = new List<Player>();
            for (int i = 0; i < roster.Count; i++)
            {
                if (roster[i].Class == playerClass)
                {
                    list.Add(roster[i]);
                    roster.RemoveAt(i);
                }
            }
            Player[] array = list.ToArray();
            return array;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var item in roster)
            {
                sb.AppendLine($"Player {item.Name}: {item.Class}");
                sb.AppendLine($"Rank: {item.Rank}");
                sb.AppendLine($"Description: {item.Description}");
            }
            return sb.ToString();
        }
    }
}
