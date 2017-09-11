namespace _06_Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        protected override string Gender
        {
            get
            {
                return base.Gender = "Male";
            }
        }

        protected override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}
