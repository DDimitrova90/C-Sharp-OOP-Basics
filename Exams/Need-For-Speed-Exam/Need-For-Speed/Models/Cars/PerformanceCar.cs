namespace Need_For_Speed.Models.Cars
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PerformanceCar : Car
    {
        public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
            : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this.AddOns = new List<string>();
            this.Horsepower += (base.Horsepower * 50) / 100;
            this.Suspension -= (base.Suspension * 25) / 100;
        }

        public List<string> AddOns { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("Add-ons: ");

            if (this.AddOns.Count() == 0)
            {
                sb.AppendLine("None");
            }
            else
            {
                sb.AppendLine(string.Join(", ", this.AddOns));
            }

            return sb.ToString().Trim();
        }

        public override void Tune(int tuneIndex, string addOn)
        {
            this.AddOns.Add(addOn);
        }
    }
}
