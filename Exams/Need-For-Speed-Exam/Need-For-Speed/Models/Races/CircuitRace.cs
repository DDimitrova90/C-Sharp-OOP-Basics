namespace Need_For_Speed.Models.Races
{
    using System.Linq;
    using System.Text;

    public class CircuitRace : Race
    {
        public CircuitRace(int length, string route, int prizePool, int laps)
            : base(length, route, prizePool)
        {
            this.Laps = laps;
        }

        public int Laps { get; set; }

        public override int GetPerformancePoints(Car car)
        {
            return (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
        }

        public override string Start()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length * this.Laps}");

            var winners = this.Participants.OrderByDescending(c => c.PerfPoints(this)).Take(4);
            int count = 1;
            int wonMoney = (this.PrizePool * 40) / 100;

            foreach (var car in winners)
            {
                if (count == 2)
                {
                    wonMoney = (this.PrizePool * 30) / 100;
                }
                else if (count == 3)
                {
                    wonMoney = (this.PrizePool * 20) / 100;
                }
                else if (count == 4)
                {
                    wonMoney = (this.PrizePool * 10) / 100;
                }

                car.DecreaseDurability(this.Length, this.Laps);

                sb.AppendLine($"{count}. {car.Brand} {car.Model} {car.PerfPoints(this)}PP - ${wonMoney}");
                count++;
            }

            return sb.ToString().Trim();
        }
    }
}
