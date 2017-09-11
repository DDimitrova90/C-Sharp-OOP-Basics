namespace _04_First_And_Reserve_Team
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                try
                {
                    var person = new Person(cmdArgs[0],
                                      cmdArgs[1],
                                      int.Parse(cmdArgs[2]),
                                      double.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }

            Team team = new Team("Gorno Nanadolnishte");

            foreach (var player in persons)
            {
                team.AddPlayer(player);
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count()} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count()} players");
        }
    }
}
