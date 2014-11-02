﻿//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and withdraw money. 
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). 
//In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. 
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation
//of the interest fuctionality through overriden methods.

using System;
using System.Collections.Generic;

namespace _02.Bank
{
    class Test
    {
        static void Main()
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new MortgageAccount(Customer.Company, -1234M, 0.8M));
            accounts.Add(new LoanAccount(Customer.Individual, -567.45M, 0.25M));
            accounts.Add(new DepositAccount(Customer.Company, 233456.23M, 0.03M));

            foreach (Account account in accounts)
            {
                Console.WriteLine("The interest amount for 5 months is: {0} %", account.CalculateInterestAmount(5));
            }
        }
    }
}
