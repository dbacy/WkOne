using System;
using System.Collections.Generic;
using System.Text;


namespace Banking
{
    class account
    {
        
        private string accountName;
        private decimal balance;
        private List<Transactions> transactions;
        private float interestRate;

        
        public string AccountName { get => accountName; set => accountName = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public float InterestRate { get => interestRate; set => interestRate = value; }
        public List<Transactions> Transactions { get => transactions; set => transactions = value; }

        
        public account(string accountName, decimal balance, float interestRate)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.interestRate = interestRate;
            transactions = new List<Transactions>();
            Transactions newAccount = new Transactions(balance, "New Account Opened: " + accountName, true);
            transactions.Add(newAccount);
        }

       
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            Transactions deposit = new Transactions(amount, "Deposit", true);
            transactions.Add(deposit);
            return Balance;
        }

        
        public decimal Withdrawal(decimal amount)
        {
            if (Balance - amount < 5.00M)
            {
                Transactions oops = new Transactions(amount, "Could not process. Balance too low", false);
                transactions.Add(oops);
                return Balance;
            }
            Balance -= amount;
            Transactions withDrawal = new Transactions(amount, "WithDrawal", true);
            transactions.Add(withDrawal);
            return Balance;
        }

         
        public void ShowTransactions()
        {
            foreach (Transactions trans in transactions)
            {
                Console.WriteLine(trans);
            }
        }

        public override string ToString()
        {
            return accountName + " : Balance = " + balance;
        }

    }
}
