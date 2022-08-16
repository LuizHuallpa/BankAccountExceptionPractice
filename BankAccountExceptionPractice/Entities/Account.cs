using BankAccountExceptionPractice.Entities.Exceptions;

namespace BankAccountExceptionPractice.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainExceptions("Error: Not enought balance to make a withdraw");
            }
            if (WithdrawLimit < amount)
            {
                throw new DomainExceptions("Error: withdraw amount above your withdraw limit");
            }

            Balance -= amount;
        }
    }
}
