namespace _06_Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            List<Team> teams = new List<Team>();

            while (line != "END")
            {
                string[] lineArgs = line
                    .Split(new char[] { ';' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (lineArgs[0])
                    {
                        case "Team":
                            CreateAndAddTeam(lineArgs, teams);
                            break;
                        case "Add":
                            AddPlayer(lineArgs, teams);
                            break;
                        case "Remove":
                            RemovePlayer(lineArgs, teams);
                            break;
                        case "Rating":
                            GetRating(lineArgs, teams);
                            break;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

                line = Console.ReadLine();
            }
        }

        private static void GetRating(string[] lineArgs, List<Team> teams)
        {
            string teamName = lineArgs[1];

            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
            else
            {
                Console.WriteLine(team.ToString());
            }
        }

        private static void RemovePlayer(string[] lineArgs, List<Team> teams)
        {
            string teamName = lineArgs[1];
            string playerName = lineArgs[2];

            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
            else
            {
                team.RemovePlayer(playerName);
            }
        }

        private static void AddPlayer(string[] lineArgs, List<Team> teams)
        {
            string teamName = lineArgs[1];
            string playerName = lineArgs[2];
            int endurance = int.Parse(lineArgs[3]);
            int sprint = int.Parse(lineArgs[4]);
            int dribble = int.Parse(lineArgs[5]);
            int passing = int.Parse(lineArgs[6]);
            int shooting = int.Parse(lineArgs[7]);

            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
            else
            {
                Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                team.AddPlayer(player);
            }
        }

        private static void CreateAndAddTeam(string[] lineArgs, List<Team> teams)
        {
            string teamName = lineArgs[1];
            Team team = new Team(teamName);
            teams.Add(team);
        }
    }
}
