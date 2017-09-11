namespace Need_For_Speed.Models
{
    using System.Text;

    public abstract class Car
    {
        public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            this.Brand = brand;
            this.Model = model;
            this.YearOfProduction = yearOfProduction;
            this.Horsepower = horsepower;
            this.Acceleration = acceleration;
            this.Suspension = suspension;
            this.Durability = durability;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int YearOfProduction { get; set; }

        public int Horsepower { get; set; }

        public int Acceleration { get; set; }

        public int Suspension { get; set; }

        public int Durability { get; set; }

        public int PerfPoints(Race race)
        {
            return race.GetPerformancePoints(this);
        }

        public abstract void Tune(int tuneIndex, string addOn);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
            sb.AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s");
            sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

            return sb.ToString().Trim();
        }

        public void DecreaseDurability(int length, int laps)
        {
            this.Durability -= length * length * laps;
        }
    }
}
