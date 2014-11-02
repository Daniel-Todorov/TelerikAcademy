using System;

namespace _02.Bank
{
    abstract class Account
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal interestRate;

        public virtual decimal CalculateInterestAmount(int months)
        {
            decimal interestAmount = 0.0M;
        
            interestAmount = this.interestRate * months;
        
            return interestAmount;
        }

        public void Deposit(decimal deposit)
        {
            this.balance = this.balance + deposit;
        }
    }
}
