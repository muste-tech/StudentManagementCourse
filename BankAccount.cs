using System;

namespace Mustakim
{
    public class BankAccount
    {
        private decimal accountBalance;

        public BankAccount(decimal initialbalance)
        {
            accountBalance = initialbalance;
        }
        public void deposit(decimal amount)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"You successfully deposited: {amount} and your new balance is: {accountBalance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }

        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= accountBalance)
            {
                accountBalance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New amount {accountBalance}");

            }
            else
            {
                Console.WriteLine("Insufficient fund");
            }


        }
        public void GetBalance()
        {
             Console.WriteLine($"Current balance: {accountBalance}");

        }
    }
}