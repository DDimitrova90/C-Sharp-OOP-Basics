namespace _06_Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int employeesNumber = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeesNumber; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string position = employeeInfo[2];
                string department = employeeInfo[3];
                string email = string.Empty;
                int age;

                Employee employee = new Employee(name, salary, position, department);

                if (employeeInfo.Length == 6)
                {
                    email = employeeInfo[4];
                    age = int.Parse(employeeInfo[5]);
                    employee.Email = email;
                    employee.Age = age;
                }
                else if (employeeInfo.Length == 5)
                {
                    if (employeeInfo[4].Contains("@"))
                    {
                        email = employeeInfo[4];
                        employee.Email = email;
                    }
                    else
                    {
                        age = int.Parse(employeeInfo[4]);
                        employee.Age = age;
                    }
                }

                employees.Add(employee);
            }

            var highestPaidDepartment = employees
                .GroupBy(e => e.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(emp => emp.Salary),
                    Employees = e.Select(emp => new
                    {
                        Name = emp.Name,
                        Salary = emp.Salary,
                        Email = emp.Email,
                        Age = emp.Age
                    })
                })
                .OrderByDescending(d => d.AverageSalary)
                .First();

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment.Department}");

            foreach (var employee in highestPaidDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
