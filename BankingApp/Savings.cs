using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Savings : Account  // this is an Inheritance class. It has access to all the public methods in the Account class.
    {
        private decimal IntRate { get; set; } = 0.01M;

        public decimal GetIntRate()
        {
            return IntRate;
        }

        public void SetIntRate(decimal NewIntRate)
        {
            IntRate = NewIntRate;
        }

        public void PayInt()
        {
            var IntToBePaid = GetBalance() * GetIntRate();
            Deposit(IntToBePaid);
        }

        public override string Print()
        {
            return base.Print() + $" interest rate = {IntRate}";
        }
        
        public Savings(string NewDescription) : base(NewDescription)
        {
            SetIntRate(0.01m);
        }
        
        public Savings() : this(null)
        {            
        }
        
    }

}
