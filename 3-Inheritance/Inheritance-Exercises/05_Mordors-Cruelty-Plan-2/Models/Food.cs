namespace _05_Mordors_Cruelty_Plan_2.Models
{
    public abstract class Food
    {
        public Food(int happinessPoints)
        {
            this.HappinessPoints = happinessPoints;
        }

        private int HappinessPoints { get; set; }

        public int GetHappinessPoints()
        {
            return this.HappinessPoints;
        }
    }
}
