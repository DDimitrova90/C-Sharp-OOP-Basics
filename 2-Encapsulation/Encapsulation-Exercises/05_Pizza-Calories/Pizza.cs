namespace _05_Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;
        private int toppingsCount;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, int toppingsCount)
        {
            this.Name = name;
            this.ToppingsCount = toppingsCount;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int ToppingsCount
        {
            get { return this.toppingsCount; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.toppingsCount = value;
            }
        }

        public Dough Dough
        {
            set { this.dough = value; }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count() < this.ToppingsCount)
            {
                this.toppings.Add(topping);
            }
        }

        public double CalculatePizzaCalories()
        {
            double doughCalories = this.dough.CalculateDoughCalories();
            double toppingsCalories = 0;

            foreach (var topping in this.toppings)
            {
                toppingsCalories += topping.CalculateToppingCalories();
            }

            return doughCalories + toppingsCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculatePizzaCalories():F2} Calories.";
        }
    }
}
