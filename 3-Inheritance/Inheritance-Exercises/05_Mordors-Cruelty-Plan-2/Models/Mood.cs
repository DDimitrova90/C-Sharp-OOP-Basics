namespace _05_Mordors_Cruelty_Plan_2.Models
{
    public abstract class Mood
    {
        public Mood(string moodType)
        {
            this.MoodType = moodType;
        }

        public string MoodType { get; set; }

        public override string ToString()
        {
            return this.MoodType;
        }
    }
}
