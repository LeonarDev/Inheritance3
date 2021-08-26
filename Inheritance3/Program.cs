using Inheritance3.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();

            accountList.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accountList.Add(new BusinessAccount(1001, "Maria", 500.0, 400.0));
            accountList.Add(new SavingsAccount(1001, "Bob", 500.0, 0.01));
            accountList.Add(new BusinessAccount(1001, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account account in accountList)
            {
                sum += account.Balance;
            }
            Console.WriteLine(sum);

            foreach (Account account in accountList)
            {
                account.Withdraw(10.0);
            }

            foreach (Account account in accountList)
            {
                Console.WriteLine($"Update balance for account {account.Number}: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
