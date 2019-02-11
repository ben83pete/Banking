using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp {
    class DepositException : Exception {
        public DepositException() : base("Deposit must be Positive.") { }

        public DepositException(string message) : base(message) { }

        public DepositException(string message, Exception innerException) : base(message, innerException) { }

    }
}
