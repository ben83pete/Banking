using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp 
{                         // IComparable is in interface.
    class Account : IComparable<Account>, IPrintable  // IComparable set this class so that data is now able to be sorted
    {
        private static int NextId = 1;
        private int Id { get; set; }
        private string Description { get; set; }
        private decimal AcctBalance { get; set; }

        public int CompareTo(Account acct) // IComparable set this class so that data is now able to be sorted
        {
            if (this.Description .Equals(acct.Description))     {
                return 0;
            }
            if (this.Description.CompareTo(acct.Description) > 0)    {
                return 1;
            }
            else     {
                return -1;
            }
        }
               
           public void TransferTo(decimal Amount, Account account)
        {
            var BeforeWithdraw = GetBalance();
            Withdrw(Amount);
            var AfterWithdraw = GetBalance();
            if(BeforeWithdraw == AfterWithdraw)
            {
                return;
            }
            account.Deposit(Amount);
        }

        public int GetID()
        {
            return Id;
        }
        public string GetDescription()
        {
            return Description;
        }
        public decimal GetBalance()
        {
            return AcctBalance;
        }

        public void SetDescription(string NewDescription)
        {
            Description = NewDescription;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit must be Positive.");
            }
            else
            {
                AcctBalance += amount;
            }
        }
        
        public void Withdrw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw must be a positive.");
                return;
            }            
            if (amount > AcctBalance)
            {
                Console.WriteLine("Insufficent Funds.");
                return;
            }            
            AcctBalance -= amount;            
            
        }
        // print statement 

        public virtual string Print()  
        {
            return $" ID = {Id}, Description =  {Description} Balance = { AcctBalance}";
        }
        
        // constructor

        public Account(string NewDescription) 
        {
            Id = NextId++;
            if (NewDescription == null)
            {
                Description = "*New Account*";
            }
            else
            {
                Description = NewDescription;
            }
            AcctBalance = 0;            
        }
        public Account() : this (null)   // This constructor calls the other constructor and passes in a null value
        {
           }

    }
}
