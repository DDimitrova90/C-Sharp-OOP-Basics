﻿namespace _06_Company_Roster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string depatment;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string positon, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = positon;
            this.Department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string Department
        {
            get { return this.depatment; }
            set { this.depatment = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
