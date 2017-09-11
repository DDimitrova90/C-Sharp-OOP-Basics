namespace _01_Vehicles
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);

            string[] truckInfo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string vehicleType = commandArgs[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);

                    if (vehicleType == "Car")
                    {    
                        car.Drive(distance);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if (command == "Refuel")
                {
                    double fuelQuantity = double.Parse(commandArgs[2]);

                    if (vehicleType == "Car")
                    {
                        car.Refuel(fuelQuantity);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(fuelQuantity);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
