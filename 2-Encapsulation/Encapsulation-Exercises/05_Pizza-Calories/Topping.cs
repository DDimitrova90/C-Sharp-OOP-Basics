namespace _05_Pizza_Calories
{
    using System;

    public class Topping
    {
        private const double Base = 2;
        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9; 

        // meat, veggies, cheese or a sauce
        private string type;
        // can be in the range [1, 50]
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            get { return this.type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && 
                    value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculateToppingCalories()
        {
            double toppingType = 0;

            if (this.Type.ToLower() == "meat")
            {
                toppingType = Meat;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                toppingType = Veggies;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                toppingType = Cheese;
            }
            else if (this.Type.ToLower() == "sauce")
            {
                toppingType = Sauce;
            }

            return Base * this.Weight * toppingType;
        }
    }
}
