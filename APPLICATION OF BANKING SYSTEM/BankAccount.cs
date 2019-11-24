using System;
namespace Banking_App_Assignment
{
    public class BankAccount
    {
        public int AccountNumber;
        private string _accountType;
        private string _currency;
        private double _initialBalance;
        private static int _accountNumberSeed = 1234567890;
        public BankAccount(string accountType, string currency)
        {
            this.AccountNumber = _accountNumberSeed;
            _accountNumberSeed++;
            this._accountType = accountType;
            this._currency = currency;
            if (currency.ToLower().Equals("rwf"))
            {
                this._initialBalance = 50000;
            }else if (currency.ToLower().Equals("usd") || currency.ToLower().Equals("euro"))
            {
                this._initialBalance = 50;
            }
        }
        public void MakeDeposit(int amount)
        {
            if (amount != 0)
            {
                _initialBalance = _initialBalance + amount;
                Console.WriteLine($"You Made a Deposit on the Account {AccountNumber}");
                Console.WriteLine($"your new balance is {_initialBalance}");
            }
            else
            {
                Console.WriteLine("Sorry you are not allowed to deposit 0 amount");
            }
        }
        public void MakeWithdraw(int amount)
        {
            if (amount <= _initialBalance)
            {
                if (amount!= 0)
                {
                    _initialBalance = _initialBalance - amount;
                    Console.WriteLine($"you withdraw {amount} on {AccountNumber} account ");
                    Console.WriteLine($"your new balance is {_initialBalance}");
                }
                else
                {
                    Console.WriteLine("You can not withdraw with 0 amount");  
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance on your account");
            }
        } 
    }
}