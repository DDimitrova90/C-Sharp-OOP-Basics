namespace Minedraft.Models.Harvesters
{
    public class HammerHarvester : Harvester
    {
        public HammerHarvester(string id, double oreOutput, double energyRequirement)
            : base(id, oreOutput, energyRequirement)
        {
            this.OreOutput += 2 * this.OreOutput;
            this.EnergyRequirement += this.EnergyRequirement;
        }
    }
}
