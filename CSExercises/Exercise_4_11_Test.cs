using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    class AccountTest
    {
        public static void LocalMain(string[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);

            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);

            Console.WriteLine("Insert deposit amount for account1: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account1 balance", depositAmount);
            account1.Credit(depositAmount);

            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);


            Console.WriteLine("Insert deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account2 balance", depositAmount);
            account2.Credit(depositAmount);

            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);

            Console.WriteLine("Insert withdraw amount for account1: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            account1.Debit(withdrawAmount);

            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);
        }
    }
}
