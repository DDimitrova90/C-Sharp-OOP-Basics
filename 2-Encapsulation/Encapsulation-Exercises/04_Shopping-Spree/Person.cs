namespace _04_Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Products
        {
            get { return this.products.AsReadOnly(); }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            if (this.products.Count() == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{this.Name} - {string.Join(", ", this.products.Select(p => p.Name))}";
        }
    }
}
