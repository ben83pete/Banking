using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {                       
        
        static void Main(string[] args)
        {

            var sav1 = new Savings("New Savings,");      
            sav1.Deposit(1500);
            sav1.Withdrw(500);
            sav1.PayInt();
            sav1.Print();

            var sav2 = new Savings("from savings to checking");        
            sav2.Deposit(1000);
            sav2.Print();

            var sav3 = new Savings("To savings");
            
            sav3.Deposit(100);
            sav3.Print();

            sav2.TransferTo(2000, sav3);
            sav3.Print();
            sav2.Print();

            var Acct1 = new Account("checking acct 1");
            Acct1.Print();
            Acct1.Deposit(1000.00);
            Acct1.Print();
            Acct1.Withdrw(50);
            Acct1.Print();

            var Acct2= new Account("savings acct 2");
            Acct2.Print();
            Acct2.Deposit(200);
            Acct2.Print();
            Acct2.Withdrw(300);
            Acct2.Print();
                       
        }
    }

}
