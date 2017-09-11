namespace _06_Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }

            return (int)Math.Round(this.players.Select(p => p.Skill()).Sum() / (double)this.players.Count);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = this.players.FirstOrDefault(p => p.Name == playerName);

            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(player);
        }

        public override string ToString()
        {
            return $"{this.Name} - {(Rating())}";
        }
    }
}
