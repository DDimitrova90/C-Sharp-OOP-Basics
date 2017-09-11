﻿namespace _06_Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        protected override string Gender
        {
            get
            {
                return base.Gender = "Female";
            }
        }

        protected override string ProduceSound()
        {
            return "Miau";
        }
    }
}
