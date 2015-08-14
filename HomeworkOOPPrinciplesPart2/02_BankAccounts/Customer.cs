using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankAccounts
{
    public abstract class Customer
    {
               
        public Customer(string name)
        {

            this.Name = name;

        }

        public string Name { get; private set; }


    }
}
