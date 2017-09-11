namespace _02_Salary_Increase
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName => this.firstName;

        public int Age => this.age;

        public void IncreaseSalary(double bonus)
        {
            if (this.age < 30)
            {
                this.salary += this.salary * (bonus / 200);
            }
            else
            {
                this.salary += this.salary * (bonus / 100);
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:F2} leva";
        }
    }
}
