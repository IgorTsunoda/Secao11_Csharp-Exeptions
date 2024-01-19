using System;
using DesafioTratamentoExcessoes.Entities.Exeption;

namespace DesafioTratamentoExcessoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

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
            if(Balance < amount )
            {
                throw new DomainException("Insuficient balance in account to do the withdraw.");
            }
            if(WithdrawLimit < amount)
            {
                throw new DomainException("Withdraw limit is not suficient to do the withdraw.");
            }
            Balance -= amount;
        }
    }
}
