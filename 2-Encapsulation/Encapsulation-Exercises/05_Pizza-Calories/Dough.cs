﻿namespace _05_Pizza_Calories
{
    using System;

    public class Dough
    {
        private const double Base = 2;
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;

        // white or wholegrain
        private string flourType;
        // crispy, chewy or homemade
        private string bakingTechnique;
        // can be in the range [1, 200]
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateDoughCalories()
        {
            double flourModifier = this.FlourType.ToLower() == "white" ? White : Wholegrain;
            double bakingModifier = this.BakingTechnique.ToLower() == "crispy" ? Crispy : this.BakingTechnique.ToLower() == "chewy" ? Chewy : Homemade;

            return (Base * this.Weight) * flourModifier * bakingModifier;
        }
    }
}
