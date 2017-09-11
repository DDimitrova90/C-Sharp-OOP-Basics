namespace _05_Mordors_Cruelty_Plan_1
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[] inputArgs = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            Gandalf gandalf = new Gandalf();

            foreach (var foodName in inputArgs)
            {
                Food food = new Food(foodName);
                gandalf.AddFood(food);
            }

            Console.WriteLine(gandalf);
        }
    }
}
