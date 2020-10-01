using System;
using System.Collections.Generic;
using System.Text;


namespace Banking
{
    class CheckingAccount:account
    {
       
      
        private account overdraftProtection;

        public account OverdraftProtection { get => overdraftProtection; set => overdraftProtection = value; }

        public CheckingAccount(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
        {
        }

        public new void Withdrawal(decimal amount)
        {
            
            if (amount > Balance)
            {
                
                if (OverdraftProtection == null)
                {
                   
                    Transactions transactions = new Transactions(amount, "No Overdraft Protection Account assigned", false);
                    Transactions.Add(transactions);
                }  
                else if (amount > Balance + OverdraftProtection.Balance + 15.00M)
                {   
                    Transactions transactions = new Transactions(amount, "Overdraft Account has Insufficient Funds", false);
                    Transactions.Add(transactions);
                }
                else
                {    
                    decimal tempAmount = amount + 15.00M;   

                    
                    tempAmount -= Balance;
                    Transactions transactions = new Transactions(Balance, "Account Withdrawal Succeeded", true);
                    Transactions.Add(transactions);
                    
                    Balance = 0;

                    
                    OverdraftProtection.Withdrawal(tempAmount);
                }
            }
            else
            {   
                Balance -= amount;
                Balance -= 1.00M;       
                Transactions transactions = new Transactions(amount, "Account Withdrawal Succeeded", true);
                Transactions.Add(transactions);
                transactions = new Transactions(1, "Withdrawal fee", true);
                Transactions.Add(transactions);
            }
        }


    }
}
