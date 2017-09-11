namespace _05_Mordors_Cruelty_Plan_1
{
    public class Food
    {
        private string name;

        public Food(string name)
        {
            this.name = name;
        }

        public int GetHappinesPoint()
        {
            switch (this.name.ToLower())
            {
                case "cram":
                    return 2;
                case "lembas":
                    return 3;
                case "apple":
                case "melon":
                    return 1;
                case "honeycake":
                    return 5;
                case "mushrooms":
                    return -10;
                default:
                    return -1;
            }
        }
    }
}
