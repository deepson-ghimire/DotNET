using System;

namespace ObjectOriented
{
    internal class BankAccountExample
    {
        public void run()
        {
            BankAccount bank = new BankAccount();

            bank.AccountNumber = 101;
            bank.AccountHolderName = "Sammannn";

            bank.Deposit(5000);
            bank.Withdraw(1500);

            Console.WriteLine("Account Number: " + bank.AccountNumber);
            Console.WriteLine("Account Holder: " + bank.AccountHolderName);
            Console.WriteLine("Current Balance: " + bank.GetBalance());
        }
    }

    public class BankAccount
    {
        private string accountHolderName;
        private int accountId;
        private double balance;

        
        public int AccountNumber
        {
            get { return accountId; }
            set { accountId = value; }
        }

       
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

       
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount or insufficient balance!");
            }
        }

      
        public double GetBalance()
        {
            return balance;
        }
    }
}