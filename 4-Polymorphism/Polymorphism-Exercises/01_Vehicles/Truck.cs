namespace _01_Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
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
            base.FuelQuantity += 0.95 * fuelQuantity;
        }
    }
}
