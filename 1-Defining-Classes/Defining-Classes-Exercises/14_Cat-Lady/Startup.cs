namespace _14_Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            List<Cat> cats = new List<Cat>();

            while (line != "End")
            {
                string[] lineArgs = line
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                string catName = lineArgs[1];

                if (lineArgs[0] == "Siamese")
                {
                    int earSize = int.Parse(lineArgs[2]);

                    if (cats.FirstOrDefault(c => c.Name == catName) == null)
                    {
                        Cat cat = new Siamese(catName, earSize);
                        cats.Add(cat);
                    }
                    else
                    {
                        Siamese cat = (Siamese)cats.First(c => c.Name == catName);
                        cat.EarSize = earSize;
                    }
                }
                else if (lineArgs[0] == "Cymric")
                {
                    double furLength = double.Parse(lineArgs[2]);

                    if (cats.FirstOrDefault(c => c.Name == catName) == null)
                    {
                        Cat cat = new Cymric(catName, furLength);
                        cats.Add(cat);
                    }
                    else
                    {
                        Cymric cat = (Cymric)cats.First(c => c.Name == catName);
                        cat.FurLength = furLength;
                    }
                }
                else if (lineArgs[0] == "StreetExtraordinaire")
                {
                    int decibelsOfMeows = int.Parse(lineArgs[2]);

                    if (cats.FirstOrDefault(c => c.Name == catName) == null)
                    {
                        Cat cat = new StreetExtraordinaire(catName, decibelsOfMeows);
                        cats.Add(cat);
                    }
                    else
                    {
                        StreetExtraordinaire cat = (StreetExtraordinaire)cats.First(c => c.Name == catName);
                        cat.DecibelsOfMeows = decibelsOfMeows;
                    }
                }

                line = Console.ReadLine();
            }

            string name = Console.ReadLine();

            Console.WriteLine(cats.First(c => c.Name == name).ToString());
        }
    }
}
