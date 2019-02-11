using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp {
    class WithdrawException : Exception {
        public WithdrawException() : base("Withdraw must be Positive.") { }

        public WithdrawException(string message) : base(message) { }

        public WithdrawException(string message, Exception innerException) : base(message, innerException) { }
            
    }
}
