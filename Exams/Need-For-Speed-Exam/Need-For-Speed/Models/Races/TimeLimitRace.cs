namespace Need_For_Speed.Models.Races
{
    using System.Linq;
    using System.Text;

    public class TimeLimitRace : Race
    {
        public TimeLimitRace(int length, string route, int prizePool, int goldTime)
            : base(length, route, prizePool)
        {
            this.GoldTime = goldTime;
        }

        public int GoldTime { get; set; }

        public override int GetPerformancePoints(Car car)
        {
            return 0;
        }

        public override void AddParticipant(Car car)
        {
            if (this.Participants.Count < 1)
            {
                this.Participants.Add(car);
            }
        }

        public override int GetTimePeformance(Car car)
        {
            return this.Length * ((car.Horsepower / 100) * car.Acceleration);
        }

        public override string GetEarnedTime()
        {
            int timePerformance = this.GetTimePeformance(this.Participants.First());

            if (timePerformance <= this.GoldTime)
            {
                return "Gold";
            }
            else if (timePerformance <= this.GoldTime + 15)
            {
                return "Silver";
            }
            else if (timePerformance > this.GoldTime + 15)
            {
                return "Bronze";
            }

            return "";
        }

        public override string Start()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length}");
            sb.AppendLine($"{this.Participants.First().Brand} {this.Participants.First().Model} – {this.GetTimePeformance(this.Participants.First())} s.");
            string earnedTime = GetEarnedTime();
            int wonPrize = GetWonPrize(earnedTime);
            sb.AppendLine($"{earnedTime} Time, ${wonPrize}.");

            return sb.ToString().Trim();
        }

        private int GetWonPrize(string earnedTime)
        {
            if (earnedTime == "Gold")
            {
                return this.PrizePool;
            }
            else if (earnedTime == "Silver")
            {
                return this.PrizePool / 2;
            }

            return (this.PrizePool * 30) / 100;
        }
    }
}
