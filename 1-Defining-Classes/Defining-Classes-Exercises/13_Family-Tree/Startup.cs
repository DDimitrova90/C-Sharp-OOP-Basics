namespace _13_Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            bool isName = !name.Contains("/");

            List<Person> family = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string firstArg = string.Empty;
                string secondArg = string.Empty;
                Person firstPerson;
                Person secondPerson;

                if (input.Contains("-"))
                {
                    string[] inputArgs = input.Split('-');
                    firstArg = inputArgs[0].Trim();
                    secondArg = inputArgs[1].Trim();

                    if (!firstArg.Contains("/") && !secondArg.Contains("/")) // two names
                    {
                        if (!CheckIfNameExists(firstArg, family))
                        {
                            firstPerson = new Person();
                            firstPerson.Name = firstArg;
                            family.Add(firstPerson);
                        }
                        else
                        {
                            firstPerson = family.First(m => m.Name == firstArg);
                        }

                        if (!CheckIfNameExists(secondArg, family))
                        {
                            secondPerson = new Person();
                            secondPerson.Name = secondArg;
                            family.Add(secondPerson);
                        }
                        else
                        {
                            secondPerson = family.First(m => m.Name == secondArg);
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                    else if (firstArg.Contains("/") && secondArg.Contains("/"))  // two dates
                    {
                        if (!CheckIfDateExists(firstArg, family))
                        {
                            firstPerson = new Person();
                            firstPerson.Birthday = firstArg;
                            family.Add(firstPerson);
                        }
                        else
                        {
                            firstPerson = family.First(m => m.Birthday == firstArg);
                        }

                        if (!CheckIfDateExists(secondArg, family))
                        {
                            secondPerson = new Person();
                            secondPerson.Birthday = secondArg;
                            family.Add(secondPerson);
                        }
                        else
                        {
                            secondPerson = family.First(m => m.Birthday == secondArg);
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                    else if (!firstArg.Contains("/") && secondArg.Contains("/")) // name and date
                    {
                        if (!CheckIfNameExists(firstArg, family))
                        {
                            firstPerson = new Person();
                            firstPerson.Name = firstArg;
                            family.Add(firstPerson);
                        }
                        else
                        {
                            firstPerson = family.First(m => m.Name == firstArg);
                        }

                        if (!CheckIfDateExists(secondArg, family))
                        {
                            secondPerson = new Person();
                            secondPerson.Birthday = secondArg;
                            family.Add(secondPerson);
                        }
                        else
                        {
                            secondPerson = family.First(m => m.Birthday == secondArg);
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                    else if (firstArg.Contains("/") && !secondArg.Contains("/"))  // date and name
                    {
                        if (!CheckIfDateExists(firstArg, family))
                        {
                            firstPerson = new Person();
                            firstPerson.Birthday = firstArg;
                            family.Add(firstPerson);
                        }
                        else
                        {
                            firstPerson = family.First(m => m.Birthday == firstArg);
                        }

                        if (!CheckIfNameExists(secondArg, family))
                        {
                            secondPerson = new Person();
                            secondPerson.Name = secondArg;
                            family.Add(secondPerson);
                        }
                        else
                        {
                            secondPerson = family.First(m => m.Name == secondArg);
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                }
                else
                {
                    string[] inputArgs = input
                        .Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);
                    firstArg = inputArgs[0] + " " + inputArgs[1];
                    secondArg = inputArgs[2];

                    Person currPersonByName = family.FirstOrDefault(m => m.Name == firstArg);
                    Person currPersonByDate = family.FirstOrDefault(m => m.Birthday == secondArg);

                    Person newPerson = new Person();
                    newPerson.Name = firstArg;
                    newPerson.Birthday = secondArg;
                    if (currPersonByName != null && currPersonByName.Parents != null)
                    {
                        newPerson.Parents.AddRange(currPersonByName.Parents);
                    }
                    if (currPersonByDate != null && currPersonByDate.Parents != null)
                    {
                        newPerson.Parents.AddRange(currPersonByDate.Parents);
                    }
                    if (currPersonByName != null && currPersonByName.Children != null)
                    {
                        newPerson.Children.AddRange(currPersonByName.Children);
                    }
                    if (currPersonByDate != null && currPersonByDate.Children != null)
                    {
                        newPerson.Children.AddRange(currPersonByDate.Children);
                    }
                    
                    family.Remove(currPersonByName);
                    family.Remove(currPersonByDate);
                    family.Add(newPerson);

                    foreach (var person in family)
                    {
                        foreach (var parent in person.Parents)
                        {
                            if (parent.Birthday == secondArg && parent.Name == null)
                            {
                                parent.Name = firstArg;
                            }
                            else if (parent.Birthday == null && parent.Name == firstArg)
                            {
                                parent.Birthday = secondArg;
                            }
                        }

                        foreach (var child in person.Children)
                        {
                            if (child.Birthday == secondArg && child.Name == null)
                            {
                                child.Name = firstArg;
                            }
                            else if (child.Birthday == null && child.Name == firstArg)
                            {
                                child.Birthday = secondArg;
                            }
                        }
                    }
                }            

                input = Console.ReadLine();
            }

            if (isName)
            {
                Console.WriteLine(family.First(m => m.Name == name).ToString());
            }
            else
            {
                Console.WriteLine(family.First(m => m.Birthday == name).ToString());
            }
        }

        private static bool CheckIfDateExists(string birthday, List<Person> family)
        {
            if (family.Where(m => m.Birthday == birthday).Count() == 0)
            {
                return false;
            }

            return true;
        }

        private static bool CheckIfNameExists(string name, List<Person> falimy)
        {
            if (falimy.Where(m => m.Name == name).Count() == 0)
            {
                return false;
            }

            return true;
        }
    }
}
