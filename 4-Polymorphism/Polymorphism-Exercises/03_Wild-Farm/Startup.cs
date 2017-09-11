namespace _03_Wild_Farm
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] animalInfo = line
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2]);
                string animalLivingRegion = animalInfo[3];

                Animal animal = null;

                switch (animalType)
                {
                    case "Mouse":
                        animal = new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                        break;
                    case "Zebra":
                        animal = new Zebra(animalName, animalType, animalWeight, animalLivingRegion);
                        break;
                    case "Cat":
                        string catBreed = animalInfo[4];
                        animal = new Cat(animalName, animalType, animalWeight, animalLivingRegion, catBreed);
                        break;
                    case "Tiger":
                        animal = new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                        break;
                }

                string[] foodInfo = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                Food food = null;

                switch (foodType)
                {
                    case "Vegetable":
                        food = new Vegetable(foodQuantity);
                        break;
                    case "Meat":
                        food = new Meat(foodQuantity);
                        break;
                }

                animal.MakeSound();
                animal.Eat(food);
                Console.WriteLine(animal.ToString());

                line = Console.ReadLine();
            }
        }
    }
}
