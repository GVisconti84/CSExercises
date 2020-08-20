using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    public class Account
    {
        private decimal balance;
        

        public Account( decimal initialBalance )
        {
            balance = initialBalance;
        }

        public void Credit( decimal amount )
        {
            balance = balance + amount;
        }

        public void Debit (decimal amount)
        {
            if (amount <= balance)
                balance = balance - amount;
            else Console.WriteLine("Debit amount exceeded account balance.");
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }

      
    }
}
