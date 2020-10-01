using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class SavingsAccount:account
    {
        public SavingsAccount(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
        {
            
            this.Deposit(100);
        }
    }
}
