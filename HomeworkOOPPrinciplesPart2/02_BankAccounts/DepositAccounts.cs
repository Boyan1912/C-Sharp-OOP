using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankAccounts
{
    public class DepositAccount : Account
    {


        public DepositAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }


        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            
            return base.CalculateInterest(months);
        }


    }
}
