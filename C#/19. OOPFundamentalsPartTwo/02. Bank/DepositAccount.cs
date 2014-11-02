using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank
{
    class DepositAccount : Account, IDeposit
    {
        //Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal CalculateInterestAmount(int months)
        {
            decimal interestAmount = 0.0M;

            if (this.balance < 0 && this.balance >= 1000)
            {
                interestAmount = this.interestRate * months;
            }

            return interestAmount;
        }

        public void Withdraw(decimal withdrawal)
        {
            this.balance = this.balance - withdrawal;
        }

        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }
    }
}
