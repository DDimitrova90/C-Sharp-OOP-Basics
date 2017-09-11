namespace Avatar.Models.Monuments
{
    public class EarthMonument : Monument
    {
        public EarthMonument(string name, int earthAffinity) 
            : base(name)
        {
            this.EarthAffinity = earthAffinity;
        }

        public int EarthAffinity { get; protected set; }

        public override int GetAffinity()
        {
            return this.EarthAffinity;
        }

        public override string ToString()
        {
            return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
        }
    }
}
