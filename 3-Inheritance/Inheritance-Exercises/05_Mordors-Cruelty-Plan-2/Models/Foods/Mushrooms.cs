namespace _05_Mordors_Cruelty_Plan_2.Models.Foods
{
    public class Mushrooms : Food
    {
        private const int HappinessPoints = -10;

        public Mushrooms() 
            : base(HappinessPoints)
        {
        }
    }
}
