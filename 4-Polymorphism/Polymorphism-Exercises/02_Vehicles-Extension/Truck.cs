namespace _02_Vehicles_Extension
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption + 1.6;
            }
        }

        public override void Drive(double distance)
        {
            if (base.FuelQuantity < distance * this.FuelConsumption)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                Console.WriteLine($"Truck travelled {distance} km");
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
                base.FuelQuantity += 0.95 * fuelQuantity;
            }
        }
    }
}
