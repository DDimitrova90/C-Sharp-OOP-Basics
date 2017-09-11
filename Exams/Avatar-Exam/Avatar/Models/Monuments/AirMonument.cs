namespace Avatar.Models.Monuments
{
    public class AirMonument : Monument
    {
        public AirMonument(string name, int airAffinity) 
            : base(name)
        {
            this.AirAffinity = airAffinity;
        }

        public int AirAffinity { get; protected set; }

        public override int GetAffinity()
        {
            return this.AirAffinity;
        }

        public override string ToString()
        {
            return $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
        }
    }
}
