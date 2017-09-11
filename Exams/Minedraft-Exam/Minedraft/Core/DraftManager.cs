namespace Minedraft
{
    using Factories;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DraftManager
    {
        private const double HalfModeEnergyValue = 0.6;
        private const double HalfModeOreValue = 0.5;
        private const double EnergyModeEnergyValue = 0;
        private const double EnergyModeOreValue = 0;

        private double totalStoredEnergy;
        private double totalMinedOre;
        private List<Harvester> harvesters;
        private List<Provider> providers;
        private HarvesterFactory harvesterFactory;
        private ProviderFactory providerFactory;
        private string mode;

        public DraftManager()
        {
            this.harvesters = new List<Harvester>();
            this.providers = new List<Provider>();
            this.harvesterFactory = new HarvesterFactory();
            this.providerFactory = new ProviderFactory();
            this.totalMinedOre = 0;
            this.totalStoredEnergy = 0;
            this.mode = "Full";
        }

        public string RegisterHarvester(List<string> arguments)
        {
            try
            {
                Harvester harvester = this.harvesterFactory.GetHarvester(arguments);
                this.harvesters.Add(harvester);
                return $"Successfully registered {harvester.GetType().Name.Replace("Harvester", "")} Harvester - {harvester.ID}";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }

        public string RegisterProvider(List<string> arguments)
        {
            try
            {
                Provider provider = this.providerFactory.GetProvider(arguments);
                this.providers.Add(provider);
                return $"Successfully registered {provider.GetType().Name.Replace("Provider", "")} Provider - {provider.ID}";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }

        public string Day()
        {
            double storedEnergy = 0;
            double minedOre = 0;

            storedEnergy = this.providers.Sum(p => p.EnergyOutput);
            this.totalStoredEnergy += storedEnergy;
            double neededEnergy = this.harvesters.Sum(h => h.EnergyRequirement);

            if (this.totalStoredEnergy >= neededEnergy)
            {
                if (mode == "Full")
                {
                    minedOre = this.harvesters.Sum(h => h.OreOutput);
                    this.totalStoredEnergy -= neededEnergy;
                }
                else if (mode == "Half")
                {
                    minedOre = this.harvesters.Sum(h => (h.OreOutput * 50) / 100);
                    this.totalStoredEnergy -= (neededEnergy * 60) / 100;
                }

                this.totalMinedOre += minedOre;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {storedEnergy}");
            sb.AppendLine($"Plumbus Ore Mined: {minedOre}");

            return sb.ToString().Trim();
        }

        public string Mode(List<string> arguments)
        {
            string modeCommand = arguments[0];

            if (modeCommand == "Half")
            {
                this.mode = "Half";
            }
            else if (modeCommand == "Energy")
            {
                this.mode = "Energy";
            }
            else if (modeCommand == "Full")
            {
                this.mode = "Full";
            }

            return $"Successfully changed working mode to {mode} Mode";
        }

        public string Check(List<string> arguments)
        {
            string id = arguments[0];
            string message = string.Empty;

            Provider provider = this.providers.FirstOrDefault(p => p.ID == id);
            Harvester harvester = this.harvesters.FirstOrDefault(h => h.ID == id);

            if (harvester != null)
            {
                message = harvester.ToString();
            }

            if (provider != null)
            {
                message = provider.ToString();
            }

            if (message != string.Empty)
            {
                return message;
            }

            return $"No element found with id - {id}";
        }

        public string ShutDown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
            sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

            return sb.ToString().Trim();
        }
    }
}
