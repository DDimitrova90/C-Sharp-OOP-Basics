namespace _03_Mankind
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[] studentInfo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            string[] workerInfo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            try
            {
                string studentFirstName = studentInfo[0];
                string studentLastName = studentInfo[1];
                string facultyNumber = studentInfo[2];
                Student student = new Student(studentFirstName, studentLastName, facultyNumber);

                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                double workHoursPerDay = double.Parse(workerInfo[3]);
                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
