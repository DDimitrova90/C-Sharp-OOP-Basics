namespace Minedraft.Models
{
    using System;
    using System.Text;

    public abstract class Provider : Worker
    {
        private string id;
        private double energyOutput;

        protected Provider(string id, double energyOutput)
        : base(id)
        {
            this.ID = id;
            this.EnergyOutput = energyOutput;
        }

        public string ID
        {
            get { return this.id; }
            protected set
            {
                if (value.Contains(" "))
                {
                    throw new ArgumentException($"Provider is not registered, because of it's {nameof(ID)}");
                }

                this.id = value;
            }
        }

        public double EnergyOutput
        {
            get { return this.energyOutput; }
            protected set
            {  
                if (value <= 0 || value >= 10000)
                {
                    throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
                }

                this.energyOutput = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name.Replace("Provider", "")} Provider - {this.ID}");
            sb.AppendLine($"Energy Output: {this.EnergyOutput}");

            return sb.ToString().Trim();
        }
    }
}
