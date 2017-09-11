namespace Need_For_Speed.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Race
    {
        public Race(int length, string route, int prizePool)
        {
            this.Length = length;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new List<Car>();
        }

        public int Length { get; set; }

        public string Route { get; set; }

        public int PrizePool { get; set; }

        public List<Car> Participants { get; set; }

        public virtual void AddParticipant(Car car)
        {
            this.Participants.Add(car);
        }

        public abstract int GetPerformancePoints(Car car);

        public virtual int GetTimePeformance(Car car)
        {
            return 0;
        }

        public virtual string Start()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length}");

            var winners = this.Participants.OrderByDescending(c => c.PerfPoints(this)).Take(3);
            int count = 1;
            int wonMoney = (this.PrizePool * 50) / 100;

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

                sb.AppendLine($"{count}. {car.Brand} {car.Model} {car.PerfPoints(this)}PP - ${wonMoney}");
                count++;
            }

            return sb.ToString().Trim();
        }

        public virtual string GetEarnedTime()
        {
            return "";
        }
    }
}
