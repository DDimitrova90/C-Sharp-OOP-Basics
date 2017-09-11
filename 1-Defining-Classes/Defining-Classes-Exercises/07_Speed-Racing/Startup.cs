namespace _07_Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int carsNumber = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsNumber; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string model = commandArgs[1];
                double amountOfKm = double.Parse(commandArgs[2]);

                Car currCar = cars.FirstOrDefault(c => c.Model == model);

                if (currCar != null)
                {
                    currCar.Drive(amountOfKm);
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
