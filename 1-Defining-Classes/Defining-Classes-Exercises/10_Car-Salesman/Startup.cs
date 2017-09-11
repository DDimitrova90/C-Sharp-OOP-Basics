namespace _10_Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int enginesNumber = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < enginesNumber; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                string displacement = string.Empty;
                string efficiency = string.Empty;
                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 4)
                {
                    engine.Displacement = engineInfo[2];
                    engine.Efficiency = engineInfo[3];
                }
                else if (engineInfo.Length == 3)
                {
                    if (char.IsLetter(engineInfo[2][0]))
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                    else
                    {
                        engine.Displacement = engineInfo[2];
                    }
                }

                engines.Add(engine);
            }

            int carsNumber = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsNumber; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];

                Engine engine = engines
                    .First(e => e.Model == engineModel);

                Car car = new Car(model, engine);

                if (carInfo.Length == 4)
                {
                    car.Weight = carInfo[2];
                    car.Color = carInfo[3];
                }
                else if (carInfo.Length == 3)
                {
                    if (char.IsDigit(carInfo[2][0]))
                    {
                        car.Weight = carInfo[2];
                    }
                    else
                    {
                        car.Color = carInfo[2];
                    }
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
