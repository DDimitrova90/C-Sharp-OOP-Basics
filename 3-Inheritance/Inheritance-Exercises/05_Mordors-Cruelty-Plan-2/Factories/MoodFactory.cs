namespace _05_Mordors_Cruelty_Plan_2.Factories
{
    using Models;
    using Models.Moods;

    public class MoodFactory
    {
        public Mood GetMood(int happinessPoints)
        {
            if (happinessPoints < -5)
            {
                return new Angry();
            }

            if (happinessPoints <= 0)
            {
                return new Sad();
            }

            if (happinessPoints <= 15)
            {
                return new Happy();
            }

            return new JavaScript();
        }
    }
}
