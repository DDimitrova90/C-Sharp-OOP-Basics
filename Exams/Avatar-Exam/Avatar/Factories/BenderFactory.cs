namespace Avatar.Factories
{
    using Models;
    using Models.Benders;

    public class BenderFactory
    {
        public Bender GetBender(string benderType, string benderName, int benderPower, double secParameter)
        {
            switch (benderType)
            {
                case "Air":
                    return new AirBender(benderName, benderPower, secParameter);
                case "Earth":
                    return new EarthBender(benderName, benderPower, secParameter);
                case "Fire":
                    return new FireBender(benderName, benderPower, secParameter);     
                default:
                    return new WaterBender(benderName, benderPower, secParameter);
            }
        }
    }
}
