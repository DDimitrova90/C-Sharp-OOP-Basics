namespace _02_Vehicles_Extension
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
            double carTankCapacity = double.Parse(carInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            string[] truckInfo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            string[] busInfo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Vehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

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
                    else if (vehicleType == "Bus")
                    {
                        bus.Drive(distance);
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
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(fuelQuantity);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    double distance = double.Parse(commandArgs[2]);
                    bus.DriveEmpty(distance);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
