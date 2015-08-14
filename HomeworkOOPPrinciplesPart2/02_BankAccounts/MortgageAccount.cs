using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankAccounts
{
    public class MortgageAccount : Account
    {

        public MortgageAccount(decimal balance, decimal interest, Customer customer)
            : base(balance, interest, customer)
        {

        }

        public DateTime PromotionDate
        {
            get
            {
                if (this.Customer is Individual)
                {
                    return this.CreationDate.AddMonths(6);
                }

                else
                {
                    return this.CreationDate.AddMonths(12);
                }

            }

        }

        public override decimal CalculateInterest(int months)
        {
            int promoMonths = 0;

            if (DateTime.Now < this.PromotionDate)
            {
                if (this.Customer is Individual)
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

                else if (this.Customer is Company)
                {
                    if (DateTime.Now.AddMonths(months) < this.PromotionDate)
                    {
                        return base.CalculateInterest(months) / 2;
                    }

                    else
                    {
                        DateTime newDate = DateTime.Now.AddMonths(months);
                        promoMonths = newDate.Month - this.PromotionDate.Month + 12 * (newDate.Year - this.PromotionDate.Year);
                        months -= promoMonths;

                        return (promoMonths * this.InterestRate / 2) + (months * this.InterestRate);

                    }

                }

            }
            
            
            return base.CalculateInterest(months);
        }



        
    }
}
