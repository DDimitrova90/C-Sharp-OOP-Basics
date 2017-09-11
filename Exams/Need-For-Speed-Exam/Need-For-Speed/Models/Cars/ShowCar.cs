namespace Need_For_Speed.Models.Cars
{
    using System.Text;

    public class ShowCar : Car
    {
        public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
            : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this.Stars = 0;
        }

        public int Stars { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.Stars} *");

            return sb.ToString().Trim();
        }

        public override void Tune(int tuneIndex, string addOn)
        {
            this.Stars += tuneIndex;
        }
    }
}
