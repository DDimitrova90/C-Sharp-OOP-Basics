namespace _01_Vehicles
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
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
            base.FuelQuantity += fuelQuantity;
        }
    }
}
