namespace _13_Family_Tree
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        public Person()
        {
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} {this.Birthday}");
            sb.AppendLine("Parents:");

            if (this.Parents.Count() > 0)
            {
                foreach (var parent in this.Parents)
                {
                    sb.AppendLine($"{parent.Name} {parent.Birthday}");
                }
            }

            sb.AppendLine("Children:");

            if (this.Children.Count() > 0)
            {
                foreach (var child in this.Children)
                {
                    sb.AppendLine($"{child.Name} {child.Birthday}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
