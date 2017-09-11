namespace _02_Vehicles_Extension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                this.fuelQuantity = value;
            }
        }

        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double fuelQuantity);

        public virtual void DriveEmpty(double distance)
        {

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
