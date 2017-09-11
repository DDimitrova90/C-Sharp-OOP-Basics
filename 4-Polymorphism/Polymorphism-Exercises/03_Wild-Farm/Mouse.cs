namespace _03_Wild_Farm
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
            {
                base.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Mouses are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }
    }
}
