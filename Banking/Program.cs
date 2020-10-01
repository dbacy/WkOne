using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance;
            string accountName;
            int menuOption = 0;
            CheckingAccount checking = null;
            SavingsAccount savings = null;
            
            
            while (menuOption != 1)
            {
                menuOption = GetNumber("1 - Exit\n2 - " +
                    "Create Checking\n3 - Create Savings\n4 - " +
                    "Check Checking Balane\n5 - Check Saving Balance\n6 -" +
                    " Deposit To Checking\n7 - Deposit To Savings ");
                switch (menuOption)
                {
                    
                    case 1:
                        break;

                    case 2:
                        accountName = GetInput("Account Name");
                        balance = GetNumber("Initial Amt: ");
                        checking = new CheckingAccount(accountName, balance, 0.02f);
                        break;

                    case 3:
                        accountName = GetInput("Account Name");
                        balance = GetNumber("Initial Amt: ");
                        savings = new SavingsAccount(accountName, balance, 0.03f);
                        break;

                    case 4:
                        Console.WriteLine("Your Checking Account currently is: " + checking);
                        break;

                    case 5:
                        Console.WriteLine("Your Saving Account currently is:" + savings);
                        break;

                    case 6:
                        accountName = GetInput("Account Name");
                        int CheckingDposit = Utils.GetNumber("How much will you be depositing?: ");
                        checking. Deposit(CheckingDposit);
                        Console.WriteLine(CheckingDposit + " Has been added");
                        break;

                    case 7:
                        accountName = GetInput("Account Name");
                        int savingDeposit = Utils.GetNumber("How much will you be depositing?: ");
                        savings.Deposit(savingDeposit);
                        Console.WriteLine(savingDeposit + " Has been added");
                        break;



                    default:
                        break;
                }
            }
        }   

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }  

        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }   

        
    }
}
