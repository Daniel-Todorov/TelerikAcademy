using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank
{
    class LoanAccount : Account, IDeposit
    {
        //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
        public override decimal CalculateInterestAmount(int months)
        {
            decimal interestAmount = 0.0M;

            if (this.customer == Customer.Company && months > 2)
            {
                interestAmount = this.interestRate * months;
            }

            if (this.customer == Customer.Individual && months > 3)
            {
                interestAmount = this.interestRate * months;
            }

            return interestAmount;
        }

        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }
    }
}
