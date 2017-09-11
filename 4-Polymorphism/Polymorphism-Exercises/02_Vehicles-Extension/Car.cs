namespace _02_Vehicles_Extension
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption + 0.9;
            }
        }

        public override void Drive(double distance)
        {
            if (base.FuelQuantity < distance * this.FuelConsumption)
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                Console.WriteLine($"Car travelled {distance} km");
                base.FuelQuantity -= distance * this.FuelConsumption;
            }
        }

        public override void Refuel(double fuelQuantity)
        {
            if (fuelQuantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (base.FuelQuantity + fuelQuantity > base.TankCapacity)
                {
                    Console.WriteLine("Cannot fit fuel in tank");
                }
                else
                {
                    base.FuelQuantity += fuelQuantity;
                }
            }
        }
    }
}
