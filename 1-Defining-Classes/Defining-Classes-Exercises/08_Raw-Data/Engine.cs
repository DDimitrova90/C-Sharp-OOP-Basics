﻿namespace _08_Raw_Data
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.Power = power;
            this.Speed = speed;
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
    }
}
