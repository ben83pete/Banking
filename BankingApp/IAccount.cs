using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp {
    interface IAccount : IPrintable {
        int GetId();
        string GetDescription();
        void SetDescription(string NewDescription);
        decimal GetBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void TransferTo(decimal amount, Account account);
    }
}
