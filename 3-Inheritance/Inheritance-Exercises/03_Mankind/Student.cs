namespace _03_Mankind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !IsFacultyNumberValid(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        private bool IsFacultyNumberValid(string facultyNumber)
        {
            foreach (var element in facultyNumber)
            {
                if (!char.IsLetter(element) && !char.IsDigit(element))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
