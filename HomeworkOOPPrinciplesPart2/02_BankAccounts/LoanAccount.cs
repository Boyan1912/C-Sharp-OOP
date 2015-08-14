using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankAccounts
{
    public class LoanAccount : Account
    {

        public LoanAccount(decimal balance, decimal interest, Customer customer)
            : base(balance, interest, customer)
        {

        }

        public DateTime PromotionDate 
        {
            get
            {
                if (this.Customer is Individual)
                {
                    return this.CreationDate.AddMonths(3);
                }

                else
                {
                    return this.CreationDate.AddMonths(2);
                }

            }
        
        }


        public override decimal CalculateInterest(int months)
        {

            
            if (DateTime.Now < this.PromotionDate)
            {
                if (DateTime.Now.AddMonths(months) < this.PromotionDate)
                {
                    return 0;
                }

                else
                {
                    DateTime newDate = DateTime.Now.AddMonths(months);
                    months = newDate.Month - this.PromotionDate.Month + 12 * (newDate.Year - this.PromotionDate.Year);
                }

            }

            return base.CalculateInterest(months);
        }
      
    }
}
