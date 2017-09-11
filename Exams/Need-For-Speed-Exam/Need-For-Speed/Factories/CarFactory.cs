namespace Need_For_Speed.Factories
{
    using Models;
    using Models.Cars;
    using System;

    public class CarFactory
    {
        public Car GetCar(string carType, string carBrand, string carModel, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            switch (carType)
            {
                case "Performance":
                    return new PerformanceCar(carBrand, carModel, yearOfProduction, horsepower, acceleration, suspension, durability);
                case "Show":
                    return new ShowCar(carBrand, carModel, yearOfProduction, horsepower, acceleration, suspension, durability);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
