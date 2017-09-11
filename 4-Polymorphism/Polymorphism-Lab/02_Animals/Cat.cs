﻿namespace _02_Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + "\nMEEOW";
        }
    }
}
