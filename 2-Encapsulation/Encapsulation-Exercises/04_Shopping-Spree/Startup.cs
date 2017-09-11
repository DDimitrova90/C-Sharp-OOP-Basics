namespace _04_Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] peopleArgs = Console.ReadLine()
                .Split(new char[] { ';' }, 
                StringSplitOptions.RemoveEmptyEntries);
            string[] productsArgs = Console.ReadLine()
                .Split(new char[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (var token in peopleArgs)
            {
                string[] personArgs = token
                    .Split(new char[] { '=' },
                StringSplitOptions.RemoveEmptyEntries);
                string name = personArgs[0];
                decimal money = decimal.Parse(personArgs[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return;
                }
            }

            foreach (var token in productsArgs)
            {
                string[] productArgs = token
                    .Split(new char[] { '=' },
                StringSplitOptions.RemoveEmptyEntries);
                string name = productArgs[0];
                decimal cost = decimal.Parse(productArgs[1]);

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return;
                }
            }

            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] lineArgs = line
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                string personName = string.Empty;
                string productName = string.Empty;

                if (lineArgs.Length == 2)
                {
                    personName = lineArgs[0];
                    productName = lineArgs[1];
                }

                if (string.IsNullOrEmpty(personName) || string.IsNullOrWhiteSpace(personName))
                {
                    Console.WriteLine("Name cannot be empty");
                    return;
                }

                if (string.IsNullOrEmpty(productName) || string.IsNullOrWhiteSpace(productName))
                {
                    Console.WriteLine("Name cannot be empty");
                    return;
                }

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (person != null && product != null)
                {
                    if (person.Money < product.Cost)
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                        person.AddProduct(product);
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
