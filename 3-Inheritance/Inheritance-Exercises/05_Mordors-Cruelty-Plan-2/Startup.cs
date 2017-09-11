namespace _05_Mordors_Cruelty_Plan_2
{
    using Factories;
    using Models;
    using System;

    public class Startup
    {
        public static void Main()
        {
            FoodFactory foodFactoy = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();
            Gandalf gandalf = new Gandalf();

            string[] inputArgs = Console.ReadLine()
                .Split(new char[] { ' ', 't', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string foodStr in inputArgs)
            {
                Food food = foodFactoy.GetFood(foodStr);
                gandalf.Eat(food);
            }

            int totalHappinessPoints = gandalf.GetHappinessPoints();
            Mood currentMood = moodFactory.GetMood(totalHappinessPoints);

            Console.WriteLine(totalHappinessPoints);
            Console.WriteLine(currentMood);
        }
    }
}
