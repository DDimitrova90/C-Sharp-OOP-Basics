namespace Avatar
{
    using Factories;
    using Models;
    using System.Collections.Generic;
    using System.Text;

    public class NationsBuilder
    {
        private BenderFactory benderFactory = new BenderFactory();
        private MonumentFactory monumentFactory = new MonumentFactory();
        private Nation nation = new Nation();
        private List<string> nationsIssuedWars = new List<string>();

        public void AssignBender(List<string> benderArgs)
        {
            string benderType = benderArgs[1];
            string benderName = benderArgs[2];
            int benderPower = int.Parse(benderArgs[3]);
            double secParameter = double.Parse(benderArgs[4]);

            Bender currBender = benderFactory.GetBender(benderType, benderName, benderPower, secParameter);
            nation.AddBender(benderType, currBender);
        }

        public void AssignMonument(List<string> monumentArgs)
        {
            string monumentType = monumentArgs[1];
            string monumentName = monumentArgs[2];
            int monumentAffinity = int.Parse(monumentArgs[3]);

            Monument currMonument = monumentFactory.GetMonument(monumentType, monumentName, monumentAffinity);
            nation.AddMonument(monumentType, currMonument);
        }

        public string GetStatus(string nationsType)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nationsType} Nation");
            sb.AppendLine(nation.ShowBenders(nationsType));
            sb.AppendLine(nation.ShowMonuments(nationsType));

            return sb.ToString().Trim();
        }

        public void IssueWar(string nationsType)
        {
            nationsIssuedWars.Add(nationsType);

            double fireTotalPower = nation.CalcuateTotalPower("Fire");
            double waterTotalPower = nation.CalcuateTotalPower("Water");
            double airTotalPower = nation.CalcuateTotalPower("Air");
            double earthTotalPower = nation.CalcuateTotalPower("Earth");

            List<double> results = new List<double>()
            { fireTotalPower, waterTotalPower, airTotalPower, earthTotalPower };
            double maxTotalPower = GetWinner(results);

            if (fireTotalPower < maxTotalPower)
            {
                DestroyArmy("Fire");
            }
            if (waterTotalPower < maxTotalPower)
            {
                DestroyArmy("Water");
            }
            if (airTotalPower < maxTotalPower)
            {
                DestroyArmy("Air");
            }
            if (earthTotalPower < maxTotalPower)
            {
                DestroyArmy("Earth");
            }
        }

        public string GetWarsRecord()
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;

            foreach (var nation in nationsIssuedWars)
            {
                sb.AppendLine($"War {count} issued by {nation}");
                count++;
            }

            return sb.ToString().Trim();
        }

        private void DestroyArmy(string nationType)
        {
            nation.DeleteBenders(nationType);
            nation.DeleteMonuments(nationType);
        }

        private double GetWinner(List<double> results)
        {
            double maxTotalPower = double.MinValue;

            foreach (var entry in results)
            {
                if (entry > maxTotalPower)
                {
                    maxTotalPower = entry;
                }
            }

            return maxTotalPower;
        }
    }
}
