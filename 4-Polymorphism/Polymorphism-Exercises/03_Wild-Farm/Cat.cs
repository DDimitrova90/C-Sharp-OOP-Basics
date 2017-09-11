namespace _03_Wild_Farm
{
    using System;

    public class Cat : Feline
    {
        private string breed;

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            protected set { this.breed = value; }
        }

        public override void Eat(Food food)
        {
            base.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {this.Breed}, {base.AnimalWeight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
