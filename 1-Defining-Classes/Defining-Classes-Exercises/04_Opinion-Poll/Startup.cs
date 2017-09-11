namespace _04_Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleNumber; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            people
                .Where(p => p.age > 30)
                .OrderBy(p => p.name)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
