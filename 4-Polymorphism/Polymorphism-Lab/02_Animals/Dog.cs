﻿namespace _02_Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + "\nDJAAF";
        }
    }
}
