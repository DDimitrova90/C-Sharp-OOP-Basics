namespace _08_Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int carsAmount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsAmount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double firstTirePressure = double.Parse(carInfo[5]);
                int firstTireAge = int.Parse(carInfo[6]);
                double secondTirePressure = double.Parse(carInfo[7]);
                int secondTireAge = int.Parse(carInfo[8]);
                double thirdTirePressure = double.Parse(carInfo[9]);
                int thirdTireAge = int.Parse(carInfo[10]);
                double forthTirePressure = double.Parse(carInfo[11]);
                int forthTireAge = int.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire firstTire = new Tire(firstTirePressure, firstTireAge);
                Tire secondTire = new Tire(secondTirePressure, secondTireAge);
                Tire thirdTire = new Tire(thirdTirePressure, thirdTireAge);
                Tire forthTire = new Tire(forthTirePressure, forthTireAge);

                Car car = new Car(carModel, engine, cargo);
                car.Tires[0] = firstTire;
                car.Tires[1] = secondTire;
                car.Tires[2] = thirdTire;
                car.Tires[3] = forthTire;

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars
                    .Where(c => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1))
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
            else if (command == "flamable")
            {
                cars
                    .Where(c => c.Cargo.Type == command && c.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
