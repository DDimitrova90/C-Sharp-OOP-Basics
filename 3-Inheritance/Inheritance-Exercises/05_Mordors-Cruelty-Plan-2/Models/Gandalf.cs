namespace _05_Mordors_Cruelty_Plan_2.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Gandalf
    {
        private List<Food> foodsEaten;

        public Gandalf()
        {
            this.foodsEaten = new List<Food>();
        }

        public void Eat(Food food)
        {
            this.foodsEaten.Add(food);
        }

        public int GetHappinessPoints()
        {
            return this.foodsEaten.Sum(f => f.GetHappinessPoints());
        }
    }
}
