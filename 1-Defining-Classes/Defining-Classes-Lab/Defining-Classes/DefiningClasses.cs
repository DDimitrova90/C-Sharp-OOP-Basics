namespace Defining_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefiningClasses
    {
        public static void Main()
        {
            // Problem 1:

            //BankAccount acc = new BankAccount();
            //acc.ID = 1;
            //acc.Balance = 15;

            //Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");

            // Problem 2:

            //BankAccount acc = new BankAccount();
            //acc.ID = 1;
            //acc.Deposit(15);
            //acc.Withdraw(5);

            //Console.WriteLine(acc.ToString());

            // Problem 3:

            string line = Console.ReadLine();
            List<BankAccount> bankAccounts = new List<BankAccount>();

            while (line != "End")
            {
                string[] lineArgs = line.Split(' ');
                string command = lineArgs[0];
                int id = int.Parse(lineArgs[1]);
                double amount;

                switch (command)
                {
                    case "Create":
                        Create(id, bankAccounts);
                        break;
                    case "Deposit":
                        amount = double.Parse(lineArgs[2]);
                        Deposit(id, amount, bankAccounts);
                        break;
                    case "Withdraw":
                        amount = double.Parse(lineArgs[2]);
                        Withdraw(id, amount, bankAccounts);
                        break;
                    case "Print":
                        Print(id, bankAccounts);
                        break;
                }

                line = Console.ReadLine();
            }
        }

        private static void Print(int id, List<BankAccount> bankAccounts)
        {
            BankAccount acc = bankAccounts.FirstOrDefault(a => a.ID == id);

            if (acc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(acc.ToString());
            }
        }

        private static void Withdraw(int id, double amount, List<BankAccount> bankAccounts)
        {
            BankAccount acc = bankAccounts.FirstOrDefault(a => a.ID == id);

            if (acc == null)
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            if (amount > acc.Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else if (amount <= acc.Balance)
            {
                acc.Withdraw(amount);
            }
        }

        private static void Deposit(int id, double amount, List<BankAccount> bankAccounts)
        {
            BankAccount acc = bankAccounts.FirstOrDefault(a => a.ID == id);

            if (acc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                acc.Deposit(amount);
            }
        }

        private static void Create(int id, List<BankAccount> bankAccounts)
        {
            if (bankAccounts.Where(a => a.ID == id).Count() == 0)
            {
                BankAccount acc = new BankAccount();
                acc.ID = id;
                bankAccounts.Add(acc);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
