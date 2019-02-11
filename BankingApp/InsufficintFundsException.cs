using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingApp {
    public class InsufficintFundsException : Exception {
        public InsufficintFundsException() : base("Insufficint Funds") { }  // Default Construtor

        public InsufficintFundsException(string Message) : base(Message) { }

        public InsufficintFundsException(string Message, Exception innerException) : base(Message, innerException) { }

    }
}
