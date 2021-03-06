﻿namespace _03_Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (!char.IsUpper(value.First()))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                }

                if (value.Length <= 3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }

                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (!char.IsUpper(value.First()))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName ");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");

            return sb.ToString().Trim();
        }
    }
}
