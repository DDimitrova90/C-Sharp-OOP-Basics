namespace Minedraft.Models
{
    using System;
    using System.Text;

    public abstract class Harvester : Worker
    {
        private string id;
        private double oreOutput;
        private double energyRequirement;

        protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
        {
            this.ID = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public string ID
        {
            get { return this.id; }
            protected set
            {
                if (value.Contains(" "))
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's {nameof(ID)}");
                }

                this.id = value;
            }
        }

        public double OreOutput
        {
            get { return this.oreOutput; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's {nameof(OreOutput)}");
                }

                this.oreOutput = value;
            }
        }

        public double EnergyRequirement
        {
            get { return this.energyRequirement; }
            protected set
            {
                if (value < 0 || value > 20000)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
                }

                this.energyRequirement = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name.Replace("Harvester", "")} Harvester - {this.ID}");
            sb.AppendLine($"Ore Output: {this.OreOutput}");
            sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString().Trim();
        }
    }
}
