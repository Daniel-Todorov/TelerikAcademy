using System;

namespace _02.Bank
{
    class MortgageAccount : Account, IDeposit
    {
        //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        public override decimal CalculateInterestAmount(int months)
        {
            decimal interestAmount = 0.0M;

            if (this.customer == Customer.Company && months <= 12)
            {
                interestAmount = (this.interestRate / 2) * months;
            }
            else
            {
                interestAmount = ((this.interestRate / 2) * 12) + (this.interestRate * (months - 12));
            }

            if (this.customer == Customer.Individual && months > 6)
            {
                interestAmount = this.interestRate * months;
            }

            return interestAmount;
        }

        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }
    }
}
