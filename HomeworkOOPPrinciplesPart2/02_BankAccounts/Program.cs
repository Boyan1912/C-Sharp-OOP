using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {

            var account = new MortgageAccount(1000M, 2M, new Individual("Anyone"));


            Console.WriteLine(account);
            Console.WriteLine(account.CalculateInterest(20));



        }
    }
}
