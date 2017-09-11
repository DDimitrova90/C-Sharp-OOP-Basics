namespace _03_Wild_Farm
{
    using System;

    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                base.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Tigers are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
