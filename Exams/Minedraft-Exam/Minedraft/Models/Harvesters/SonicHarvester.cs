namespace Minedraft.Models.Harvesters
{
    using System;

    public class SonicHarvester : Harvester
    {
        private int sonicFactor;

        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
            : base(id, oreOutput, energyRequirement)
        {
            this.SonicFactor = sonicFactor;
            this.EnergyRequirement /= this.SonicFactor;
        }

        public int SonicFactor
        {
            get { return this.sonicFactor; }
            protected set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's {nameof(SonicFactor)}");
                }

                this.sonicFactor = value;
            }
        }
    }
}
