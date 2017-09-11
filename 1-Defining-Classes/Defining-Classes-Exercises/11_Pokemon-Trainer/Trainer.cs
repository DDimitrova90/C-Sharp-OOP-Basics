namespace _11_Pokemon_Trainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.BadgesNumber = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int BadgesNumber { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesNumber} {this.Pokemons.Count()}";
        }
    }
}
