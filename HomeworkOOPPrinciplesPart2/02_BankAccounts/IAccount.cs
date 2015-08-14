using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankAccounts
{
    public interface IAccount
    {
       
        
        decimal InterestRate { get; set; }
        decimal Balance { get; set; }
        Customer Customer { get; }

        DateTime CreationDate { get; }

        decimal CalculateInterest(int months);

        




    }
}
