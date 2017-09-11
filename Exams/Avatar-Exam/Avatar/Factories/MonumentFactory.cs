namespace Avatar.Factories
{
    using Models;
    using Models.Monuments;

    public class MonumentFactory
    {
        public Monument GetMonument(string monumentType, string monumentName, int monumentAffinity)
        {
            switch (monumentType)
            {
                case "Air":
                    return new AirMonument(monumentName, monumentAffinity);
                case "Earth":
                    return new EarthMonument(monumentName, monumentAffinity);
                case "Fire":
                    return new FireMonument(monumentName, monumentAffinity);
                default:
                    return new WaterMonument(monumentName, monumentAffinity);
            }
        }
    }
}
