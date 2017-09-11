namespace _12_Google
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Relative>();
            this.Children = new List<Relative>();
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public List<Relative> Parents { get; set; }

        public List<Relative> Children { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine("Company:");
            if (this.Company != null)
            {
                sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");
            }
           
            sb.AppendLine("Car:");
            if (this.Car != null)
            {
                sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }
            
            sb.AppendLine("Pokemon:");

            foreach (var pokemon in this.Pokemons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }

            sb.AppendLine("Parents:");

            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }

            sb.AppendLine("Children:");

            foreach (var child in this.Children)
            {
                sb.AppendLine($"{child.Name} {child.Birthday}");
            }

            return sb.ToString().Trim();
        }
    }
}
