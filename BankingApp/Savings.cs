using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Savings : Account  // this is an Inheritance class. It has access to all the public methods in the Account class.
    {
        private double IntRate { get; set; } = 0.01;

        public double GetIntRate()
        {
            return IntRate;
        }

        public void SetIntRate(double NewIntRate)
        {
            IntRate = NewIntRate;
        }

        public void PayInt()
        {
            var IntToBePaid = GetBalance() * GetIntRate();
            Deposit(IntToBePaid);
        }

        public Savings(string NewDescription) : base(NewDescription)
        {
            SetIntRate(0.01);
        }
        
        public Savings() : this(null)
        {            
        }
        
    }

}
