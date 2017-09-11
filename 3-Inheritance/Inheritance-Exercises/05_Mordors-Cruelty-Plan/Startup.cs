namespace _05_Mordors_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using static FoodFactory;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Gandalf gandalf = new Gandalf();

            var foods = FoodFactory.ProduceFood(input);
            MoodFactory.ChangeMood(gandalf, foods);

            Console.WriteLine(gandalf);
        }
    }

    public static class FoodFactory
    {
        public static IList<IFood> ProduceFood(string input)
        {
            List<IFood> foods = new List<IFood>();
            string[] inputArgs = input
                .ToLower()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var food in inputArgs)
            {
                switch (food)
                {
                    case "cram":
                        foods.Add(new Cram());
                        break;
                    case "lembas":
                        foods.Add(new Lembas());
                        break;
                    case "apple":
                        foods.Add(new Apple());
                        break;
                    case "melon":
                        foods.Add(new Melon());
                        break;
                    case "honeycake":
                        foods.Add(new HoneyCake());
                        break;
                    case "mushrooms":
                        foods.Add(new Mushrooms());
                        break;
                    default:
                        foods.Add(new OtherFood());
                        break;
                }
            }

            return foods;
        }

        public static class MoodFactory
        {
            public static void ChangeMood(IMood mood, IList<IFood> foods)
            {
                foreach (var food in foods)
                {
                    mood.Mood += food.Happiness;
                }
            }
        }

        public interface IMood
        {
            int Mood { get; set; }
        }

        public class Gandalf : IMood
        {
            public Gandalf(int mood = 0)
            {
                this.Mood = mood;
            }

            public int Mood { get; set; }

            private string MoodType()
            {
                if (this.Mood < -5)
                {
                    return "Angry";
                }
                if (this.Mood >= -5 && this.Mood < 0)
                {
                    return "Sad";
                }
                if (this.Mood >= 0 && this.Mood <= 15)
                {
                    return "Happy";
                }

                return "JavaScript";
            }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(this.Mood)
                    .Append(Environment.NewLine)
                    .Append(this.MoodType());

                return builder.ToString();
            }
        }

        public interface IFood
        {
            int Happiness { get; }
        }

        public abstract class Food : IFood
        {
            protected Food(int happiness)
            {
                this.Happiness = happiness;
            }

            public int Happiness { get; set; }
        }

        public class Cram : Food
        {
            private const int CramHappiness = 2;

            public Cram()
                : base(CramHappiness)
            {
            }
        }

        public class Lembas : Food
        {
            private const int LembasHappiness = 3;

            public Lembas()
                : base(LembasHappiness)
            {
            }
        }

        public class Apple : Food
        {
            private const int AppleHappiness = 1;

            public Apple()
                : base(AppleHappiness)
            {
            }
        }

        public class Melon : Food
        {
            private const int MelonHappiness = 1;

            public Melon()
                : base(MelonHappiness)
            {
            }
        }

        public class HoneyCake : Food
        {
            private const int HoneyCakeHappiness = 5;

            public HoneyCake()
                : base(HoneyCakeHappiness)
            {
            }
        }

        public class Mushrooms : Food
        {
            private const int MushroomsHappiness = -10;

            public Mushrooms()
                : base(MushroomsHappiness)
            {
            }
        }

        public class OtherFood : Food
        {
            private const int OtherFoodHappiness = -1;

            public OtherFood()
                : base(OtherFoodHappiness)
            {
            }
        }
    }
}
