namespace Avatar.Models
{
    using Monuments;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Nation
    {
        private List<Bender> FireBenders { get; set; }

        private List<Bender> AirBenders { get; set; }

        private List<Bender> EarthBenders { get; set; }

        private List<Bender> WaterBenders { get; set; }

        private List<Monument> FireMonuments { get; set; }

        private List<Monument> AirMonuments { get; set; }

        private List<Monument> EarthMonuments { get; set; }

        private List<Monument> WaterMonuments { get; set; }

        private List<Bender> benders = new List<Bender>();

        private List<Monument> monuments = new List<Monument>();

        public Nation()
        {
            this.FireBenders = new List<Bender>();
            this.AirBenders = new List<Bender>();
            this.EarthBenders = new List<Bender>();
            this.WaterBenders = new List<Bender>();
            this.FireMonuments = new List<Monument>();
            this.AirMonuments = new List<Monument>();
            this.EarthMonuments = new List<Monument>();
            this.WaterMonuments = new List<Monument>();
        }

        public void AddBender(string benderType, Bender bender)
        {
            switch (benderType)
            {
                case "Air":
                    AirBenders.Add(bender);
                    break;
                case "Fire":
                    FireBenders.Add(bender);
                    break;
                case "Earth":
                    EarthBenders.Add(bender);
                    break; ;
                default:
                    WaterBenders.Add(bender);
                    break;
            }
        }

        public void AddMonument(string monumentType, Monument monument)
        {
            switch (monumentType)
            {
                case "Air":
                    AirMonuments.Add(monument);
                    break;
                case "Fire":
                    FireMonuments.Add(monument);
                    break;
                case "Earth":
                    EarthMonuments.Add(monument);
                    break;
                default:
                    WaterMonuments.Add(monument);
                    break;
            }
        }

        public int CalculateBonus(string nationType)
        {
            int sum = 0;

            switch (nationType)
            {
                case "Air":
                    monuments = this.AirMonuments;
                    break;
                case "Fire":
                    monuments = this.FireMonuments;
                    break;
                case "Earth":
                    monuments = this.EarthMonuments;
                    break;
                default:
                    monuments = this.WaterMonuments;
                    break;
            }

            foreach (var monument in monuments)
            {
                sum += monument.GetAffinity();
            }

            return sum;
        }

        public string ShowBenders(string nationType)
        {
            StringBuilder sb = new StringBuilder();

            switch (nationType)
            {
                case "Air":
                    benders = this.AirBenders;
                    break;
                case "Fire":
                    benders = this.FireBenders;
                    break;
                case "Earth":
                    benders = this.EarthBenders;
                    break;
                default:
                    benders = this.WaterBenders;
                    break;
            }

            if (benders.Count() == 0)
            {
                sb.AppendLine("Benders: None");
            }
            else
            {
                sb.AppendLine("Benders:");

                foreach (var bender in benders)
                {
                    sb.Append("###");
                    sb.AppendLine(bender.ToString());
                }
            }

            return sb.ToString().Trim();
        }

        public string ShowMonuments(string nationType)
        {
            StringBuilder sb = new StringBuilder();

            switch (nationType)
            {
                case "Air":
                    monuments = this.AirMonuments;
                    break;
                case "Fire":
                    monuments = this.FireMonuments;
                    break;
                case "Earth":
                    monuments = this.EarthMonuments;
                    break;
                default:
                    monuments = this.WaterMonuments;
                    break;
            }

            if (monuments.Count() == 0)
            {
                sb.AppendLine("Monuments: None");
            }
            else
            {
                sb.AppendLine("Monuments:");

                foreach (var monument in monuments)
                {
                    sb.Append("###");
                    sb.AppendLine(monument.ToString());
                }
            }

            return sb.ToString().Trim();
        }

        public double CalcuateTotalPower(string nationType)
        {
            double sum = 0;

            switch (nationType)
            {
                case "Air":
                    benders = this.AirBenders;
                    break;
                case "Fire":
                    benders = this.FireBenders;
                    break;
                case "Earth":
                    benders = this.EarthBenders;
                    break;
                default:
                    benders = this.WaterBenders;
                    break;
            }

            foreach (var bender in benders)
            {
                sum += bender.CalculatePower();
            }

            int bonus = CalculateBonus(nationType);
            sum += (sum / 100) * bonus;

            return sum;
        }

        public void DeleteBenders(string nationType)
        {
            switch (nationType)
            {
                case "Air":
                    benders = this.AirBenders;
                    break;
                case "Fire":
                    benders = this.FireBenders;
                    break;
                case "Earth":
                    benders = this.EarthBenders;
                    break;
                default:
                    benders = this.WaterBenders;
                    break;
            }

            benders.Clear();
        }

        public void DeleteMonuments(string nationType)
        {
            switch (nationType)
            {
                case "Air":
                    monuments = this.AirMonuments;
                    break;
                case "Fire":
                    monuments = this.FireMonuments;
                    break;
                case "Earth":
                    monuments = this.EarthMonuments;
                    break;
                default:
                    monuments = this.WaterMonuments;
                    break;
            }

            monuments.Clear();
        }
    }
}
