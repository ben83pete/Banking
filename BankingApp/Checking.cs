using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Checking : Account
    {
        public int NextCheckNumber { get; set; } = 1;

        public int GetNextCheckNumber()
        { 
            return NextCheckNumber;
        }
        public override string Print()
        {
            return base.Print() + $" Check Number ={ NextCheckNumber}"; 
        }
        public Checking(string NewDescription) : base(NewDescription){
        }
        public Checking() : this(null){
         }
    }
}
