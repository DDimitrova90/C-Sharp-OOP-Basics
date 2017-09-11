namespace _06_Animals
{
    using System;
    using System.Text;

    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        protected int Age
        {
            get { return this.age; }

            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        protected virtual string Gender
        {
            get { return this.gender; }

            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString()) || (value.ToLower() != "female" && value.ToLower() != "male"))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        protected virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append(ProduceSound());

            return sb.ToString();
        }
    }
}
