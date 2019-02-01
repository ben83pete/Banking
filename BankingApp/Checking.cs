﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Checking  // This is a composition class, with the Account class listed as a variable.  we can call methods from the account class'
                    //
    {
        private Account account { get; set; }
    
        public int NextCheckNumber { get; set; } = 1001;

        public int GetNextCheckNumber()
        { 
            return NextCheckNumber;
        }
        public int GetId()
        {
            return account.GetID();
        }
        public double GetBalance()
        {
            return (double) account.GetBalance();
        }
        public void Deposit(decimal amount)
        {
             account.Deposit(amount);
        }
        public void Withdraw(decimal amount)
        {
             account.Withdrw(amount);
        }
        public string GetDescription()
        {
            return account.GetDescription();
        }
        public void SetDescription(string NewDescription)
        {
            account.SetDescription(NewDescription);
        }
        public string Print()
        {
            return account.Print() + $" Check Number ={ NextCheckNumber}"; 
        }
        public Checking(string NewDescription)
        {
            account = new Account(NewDescription);
        }
        public Checking():this(null)
        {
        }
    }
}
