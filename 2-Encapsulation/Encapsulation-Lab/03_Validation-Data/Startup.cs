﻿namespace _03_Validation_Data
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                try
                {
                    var person = new Person(cmdArgs[0],
                                      cmdArgs[1],
                                      int.Parse(cmdArgs[2]),
                                      double.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
              
            }

            var bonus = double.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
