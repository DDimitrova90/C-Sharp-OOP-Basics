namespace _07_Speed_Racing
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private double distanceTravelled;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1km;
            this.DistanceTravelled = 0;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionFor1km
        {
            get { return this.fuelConsumptionFor1km; }
            set { this.fuelConsumptionFor1km = value; }
        }

        public double DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public void Drive(double amountOfKm)
        {
            if ((amountOfKm * this.FuelConsumptionFor1km) > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= amountOfKm * this.FuelConsumptionFor1km;
                this.DistanceTravelled += amountOfKm;
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTravelled}";
        }
    }
}
