﻿using System;

public class MortgageAccount : BankAccount
{
    public override decimal DepositeMoney(decimal money) 
    {
        return this.Balance += money;
    }
    
    /*Mortgage accounts have ½ interest for the first 12 months for companies 
    * and no interest for the first 6 months for individuals. */
    public override decimal CalculateInterestAmount() 
    {
        if (this.Customer.TypeOfCustomer == TypeOfCustomer.Company)
        {
            if (this.PeriodInMonths > 12)
            {
                int lastPeriod = this.PeriodInMonths - 12;
                this.InterestAmount = (12 * (this.InterestRate/2)) + (lastPeriod*this.InterestRate);
                return this.InterestAmount;
            }
            else if (this.PeriodInMonths < 12)
            {
                this.InterestAmount = this.PeriodInMonths * (this.InterestRate / 2);
            }         
        }
        if (this.Customer.TypeOfCustomer == TypeOfCustomer.Individual)
        {
            if (this.PeriodInMonths < 6)
            {
                return 0;
            }
            else
            {
                this.InterestAmount = this.PeriodInMonths * this.InterestRate;
                return this.InterestAmount;
            }
        }
        this.InterestAmount = this.PeriodInMonths * this.InterestRate;
        return this.InterestAmount; 
    }

    public MortgageAccount(Customer customer, decimal balance, decimal interestRate, int periodInMonths)
        : base(customer, balance, interestRate, periodInMonths)
    {        
    }
}

