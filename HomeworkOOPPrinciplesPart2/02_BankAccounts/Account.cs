using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankAccounts
{
    public class Account : IAccount
    {

        private decimal interestRate;
        private decimal balance;
        private Customer customer;
        private DateTime creationDate;

        public Account(decimal balance, decimal interest, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interest;
            this.customer = customer;
            this.creationDate = DateTime.Now;
        }


        public decimal InterestRate 
        { 
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }


        public decimal Balance 
        {
            
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
            
        }

        public Customer Customer
        {
            get
            {
                if (this.customer == null)
                {
                    throw new ArgumentNullException("Each account must have a customer!");
                }

                return this.customer;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return this.creationDate;
            }
        }


        public virtual decimal CalculateInterest(int months)
        {
            return months * this.interestRate;
        }
   
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override string ToString()
        {

            return string.Format("Bank Account:\nCustomer: {0}\nDate Created: {1}\nBalance: {2}\nIneterest Rate: {3}", this.Customer.Name, this.CreationDate, this.Balance, this.InterestRate);
        }



    }
}
