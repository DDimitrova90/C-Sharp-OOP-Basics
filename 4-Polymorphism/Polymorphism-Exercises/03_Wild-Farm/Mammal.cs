namespace _03_Wild_Farm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return this.livingRegion; }
            protected set { this.livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
