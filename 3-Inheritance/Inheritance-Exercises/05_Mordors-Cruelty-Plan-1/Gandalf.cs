namespace _05_Mordors_Cruelty_Plan_1
{
    using System.Collections.Generic;
    using System.Text;

    public class Gandalf
    {
        private List<Food> foods;

        public Gandalf()
        {
            this.foods = new List<Food>();
        }

        public void AddFood(Food food)
        {
            this.foods.Add(food);
        }

        private int GetTotalHappinessPoints()
        {
            int totalHappinessPoints = 0;

            foreach (var food in this.foods)
            {
                totalHappinessPoints += food.GetHappinesPoint();
            }

            return totalHappinessPoints;
        }

        private string GetMood()
        {
            
            string mood = string.Empty;

            int totalHappinessPoints = GetTotalHappinessPoints();

            if (totalHappinessPoints < -5)
            {
                mood = "Angry";
            }
            else if (totalHappinessPoints >= -5 && totalHappinessPoints <= 0)
            {
                mood = "Sad";
            }
            else if (totalHappinessPoints >= 1 && totalHappinessPoints <= 15)
            {
                mood = "Happy";
            }
            else if (totalHappinessPoints > 15)
            {
                mood = "JavaScript";
            }

            return mood;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetTotalHappinessPoints()}");
            sb.Append($"{GetMood()}");

            return sb.ToString();
        }
    }
}
