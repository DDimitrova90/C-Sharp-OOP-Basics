namespace Avatar
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            NationsBuilder nationsBuilder = new NationsBuilder();

            while (command != "Quit")
            {
                List<string> commandArgs = command
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string commandType = commandArgs[0];
                string nationType = commandArgs[1];

                switch (commandType)
                {
                    case "Bender":
                        nationsBuilder.AssignBender(commandArgs);
                        break;
                    case "Monument":
                        nationsBuilder.AssignMonument(commandArgs);
                        break;
                    case "Status":
                        Console.WriteLine(nationsBuilder.GetStatus(nationType));
                        break;
                    case "War":
                        nationsBuilder.IssueWar(nationType);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(nationsBuilder.GetWarsRecord());
        }
    }
}
