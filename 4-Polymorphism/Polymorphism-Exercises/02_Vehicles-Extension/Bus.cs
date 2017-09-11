namespace _02_Vehicles_Extension
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (base.FuelQuantity < distance * (this.FuelConsumption + 1.4))
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                Console.WriteLine($"Bus travelled {distance} km");
                base.FuelQuantity -= distance * (this.FuelConsumption + 1.4);
            }
        }

        public override void DriveEmpty(double distance)
        {
            if (base.FuelQuantity < distance * this.FuelConsumption)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                Console.WriteLine($"Bus travelled {distance} km");
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
