using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankExample
    {
        /*2.	A bank holds different types of accounts for its customers: 
         * deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.*/

        /*All accounts have customer, balance and interest rate (monthly based). 
         * Deposit accounts are allowed to deposit and with draw money. 
         * Loan and mortgage accounts can only deposit money.*/

        /*All accounts can calculate their interest amount for a given period (in months). 
         * In the common case its is calculated as follows: number_of_months * interest_rate.*/

        /*Loan accounts have no interest for the first 3 months 
         * if are held by individuals and for the first 2 months if are held by a company.*/

        /* Deposit accounts have no interest if their balance is positive and less than 1000. */

        /* Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.*/
        static void Main()
        {
            //create customers
            Person person = new Person("Tervel", "Kubratov", "Sofia");
            Person someone = new Person("King", "Arthur", "Dublin");
            Company company = new Company("Tervel OOD", "Sofia", TypeOfFirm.LTD);

            //create aacounts, interest 3% = 0.03M
            DepositAccount depositPerson = new DepositAccount(person, 450.00M, 0.03M, 4);
            depositPerson.Balance = depositPerson.DepositeMoney(2400M);
            Console.WriteLine("Balance of {0} is {1:C3}", person.FirstName, depositPerson.Balance);
            Console.WriteLine("Interest Amount of deposit {0} is {1}", person.FirstName, depositPerson.CalculateInterestAmount());
            LoanAccount loanPerson = new LoanAccount(person, 3200.0M, 0.04M, 13);
            Console.WriteLine("Interest Amount of loan {0} is {1}", person.FirstName, loanPerson.CalculateInterestAmount());
            MortgageAccount mortgagePerson = new MortgageAccount(person, 5060.80M, 0.05M, 14);
            Console.WriteLine("Interest Amount of mortgage {0} is {1}", person.FirstName, mortgagePerson.CalculateInterestAmount());

            Console.WriteLine();
            DepositAccount depositSomeone = new DepositAccount(someone, 3000.50M, 0.023M, 2);
            Console.WriteLine("Balance of {0} is {1:C3}", someone.FirstName, depositSomeone.Balance);

            Console.WriteLine();
            DepositAccount depositSome = new DepositAccount(company, 500.0M, 0.07M, 5);
            Console.WriteLine("Balance of \"{0}\" is {1:C3}", company.CompanyName, depositSome.Balance);
            Console.WriteLine("Interest Amount of deposit {0} is {1}", company.CompanyName, depositSome.CalculateInterestAmount());
            MortgageAccount mortgageCompany = new MortgageAccount(company, 2500.00M, 0.05M, 13);
            Console.WriteLine("Interest Amount of mortgage {0} is {1}", company.CompanyName, mortgageCompany.CalculateInterestAmount());
        }
    }
}
