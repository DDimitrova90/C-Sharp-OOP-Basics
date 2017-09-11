namespace _12_Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (line != "End")
            {
                string[] lineArgs = line
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string personName = lineArgs[0];
                Person person;

                if (people.Any(p => p.Name == personName))
                {
                    person = people.First(p => p.Name == personName);
                }
                else
                {
                    person = new Person(personName);
                    people.Add(person);
                }

                if (lineArgs[1] == "company")
                {
                    string companyName = lineArgs[2];
                    string department = lineArgs[3];
                    decimal salary = decimal.Parse(lineArgs[4]);

                    if (person.Company == null)
                    {
                        Company company = new Company(companyName, department, salary);
                        person.Company = company;
                    }
                    else
                    {
                        person.Company.Name = companyName;
                        person.Company.Department = department;
                        person.Company.Salary = salary;
                    }
                }
                else if (lineArgs[1] == "car")
                {
                    string carModel = lineArgs[2];
                    int carSpeed = int.Parse(lineArgs[3]);

                    if (person.Car == null)
                    {
                        Car car = new Car(carModel, carSpeed);
                        person.Car = car;
                    }
                    else
                    {
                        person.Car.Model = carModel;
                        person.Car.Speed = carSpeed;
                    }
                }
                else if (lineArgs[1] == "parents")
                {
                    string name = lineArgs[2];
                    string birthday = lineArgs[3];
                    Relative parent = new Relative(name, birthday);
                    person.Parents.Add(parent);
                }
                else if (lineArgs[1] == "children")
                {
                    string name = lineArgs[2];
                    string birthday = lineArgs[3];
                    Relative child = new Relative(name, birthday);
                    person.Children.Add(child);
                }
                else if (lineArgs[1] == "pokemon")
                {
                    string pokemonName = lineArgs[2];
                    string pokemonType = lineArgs[3];
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                    person.Pokemons.Add(pokemon);
                }

                line = Console.ReadLine();
            }

            string wantedName = Console.ReadLine();

            Person wantedPerson = people.FirstOrDefault(p => p.Name == wantedName);

            Console.WriteLine(wantedPerson.ToString());
        }
    }
}
