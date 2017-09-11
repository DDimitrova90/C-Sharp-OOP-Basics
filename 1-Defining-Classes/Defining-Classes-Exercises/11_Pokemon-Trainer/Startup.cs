namespace _11_Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (line != "Tournament")
            {
                string[] lineArgs = line
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string trainerName = lineArgs[0];
                string pokemonName = lineArgs[1];
                string pokemonElement = lineArgs[2];
                int pokemonHealth = int.Parse(lineArgs[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Where(t => t.Name == trainerName).Count() == 0)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    Trainer trainer = trainers.First(t => t.Name == trainerName);
                    trainer.Pokemons.Add(pokemon);
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == line))
                    {
                        trainer.BadgesNumber += 1;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;

                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.Remove(trainer.Pokemons[i]);
                            }
                        }
                    }
                }

                line = Console.ReadLine();
            }

            var sortedTrainers = trainers.OrderByDescending(t => t.BadgesNumber);

            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
