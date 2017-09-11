namespace _14_Cat_Lady
{
    public class Cat
    {
        public Cat(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    public class Siamese : Cat
    {
        public Siamese(string name, int earSize) : base(name)
        {
            this.EarSize = earSize;
        }

        public int EarSize { get; set; }

        public override string ToString()
        {
            return $"Siamese {this.Name} {this.EarSize}";
        }
    }

    public class Cymric : Cat
    {
        public Cymric(string name, double furLength) : base(name)
        {
            this.FurLength = furLength;
        }

        public double FurLength { get; set; }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.FurLength:F2}";
        }
    }

    public class StreetExtraordinaire : Cat
    {
        public StreetExtraordinaire(string name, int decibelsOfMeows) : base(name)
        {
            this.DecibelsOfMeows = decibelsOfMeows;
        }

        public int DecibelsOfMeows { get; set; }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.Name} {this.DecibelsOfMeows}";
        }
    }
}
