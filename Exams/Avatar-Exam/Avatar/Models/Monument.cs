namespace Avatar.Models
{
    public abstract class Monument
    {
        public Monument(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }

        public abstract int GetAffinity();

        public override string ToString()
        {
            return "";
        }
    }
}
