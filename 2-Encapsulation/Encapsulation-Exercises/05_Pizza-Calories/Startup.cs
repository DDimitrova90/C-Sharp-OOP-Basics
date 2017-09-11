namespace _05_Pizza_Calories
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] lineArgs = line
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (lineArgs[0])
                    {
                        case "Pizza":
                            AddPizza(lineArgs);
                            break;
                        case "Dough":
                            AddDough(lineArgs);
                            break;
                        case "Topping":
                            AddTopping(lineArgs);
                            break;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return;
                }
               

                line = Console.ReadLine();
            }
        }

        private static void AddPizza(string[] lineArgs)
        {
            string pizzaName = lineArgs[1];
            int toppingsCount = int.Parse(lineArgs[2]);
            Pizza pizza = new Pizza(pizzaName, toppingsCount);

            lineArgs = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string flourType = lineArgs[1];
            string bakingTechnique = lineArgs[2];
            double weight = double.Parse(lineArgs[3]);
            Dough dough = new Dough(flourType, bakingTechnique, weight);
            pizza.Dough = dough;

            for (int i = 0; i < pizza.ToppingsCount; i++)
            {
                lineArgs = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

                string type = lineArgs[1];
                double toppingWeight = double.Parse(lineArgs[2]);
                Topping topping = new Topping(type, toppingWeight);
                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza.ToString());
        }

        private static void AddDough(string[] lineArgs)
        {
            string flourType = lineArgs[1];
            string bakingTechnique = lineArgs[2];
            double weight = double.Parse(lineArgs[3]);
            Dough dough = new Dough(flourType, bakingTechnique, weight);

            Console.WriteLine($"{dough.CalculateDoughCalories():F2}");
        }

        private static void AddTopping(string[] lineArgs)
        {
            string type = lineArgs[1];
            double weight = double.Parse(lineArgs[2]);
            Topping topping = new Topping(type, weight);

            Console.WriteLine($"{topping.CalculateToppingCalories():F2}");
        }
    }
}
