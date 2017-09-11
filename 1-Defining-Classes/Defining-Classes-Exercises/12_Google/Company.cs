namespace _12_Google
{
    public class Company
    {
        public Company(string name, string depatment, decimal salary)
        {
            this.Name = name;
            this.Department = depatment;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }
    }
}
