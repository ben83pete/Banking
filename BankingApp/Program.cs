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
            var chk1 = new Checking("My first checking account");
            Console.WriteLine(chk1.Print());
            chk1.Deposit(500);
            Console.WriteLine(chk1.Print());
            chk1.Withdraw(200);
            Console.WriteLine(chk1.Print());

            var chk2 = new Checking();
            chk2.Deposit(500);
            Console.WriteLine(chk2.Print());

            var sav1 = new Savings("New Savings,");      
            sav1.Deposit(1500);
            sav1.Withdrw(500);
            sav1.PayInt();
            Console.WriteLine(sav1.Print());

            var sav2 = new Savings("from savings to checking");        
            sav2.Deposit(1000);
            Console.WriteLine( sav2.Print());

            var sav3 = new Savings("To savings");
            sav3.Deposit(100);
            Console.WriteLine(sav3.Print());

            /* List<Account> accounts = new List<Account>();
             accounts.Add(chk1);
             accounts.Add(chk2);
             accounts.Add(sav1);
             accounts.Add(sav2);
             accounts.Add(sav3);

             foreach(var account in accounts)
             {
                 Console.WriteLine(account.Print());
             }
             */

            sav3.Deposit(100);
            Console.WriteLine(sav3.Print());

            sav2.TransferTo(2000, sav3);
            Console.WriteLine(sav3.Print());
            Console.WriteLine(sav2.Print());

            var Acct1 = new Account("checking acct 1");
            Console.WriteLine(Acct1.Print());
            Acct1.Deposit(1000);
            Console.WriteLine(Acct1.Print());
            Acct1.Withdrw(50);
            Console.WriteLine(Acct1.Print());

            var Acct2 = new Account("savings acct 2");
            Console.WriteLine(Acct2.Print());
            Acct2.Deposit(200);
            Console.WriteLine(Acct2.Print());
            Acct2.Withdrw(300);
            Console.WriteLine(Acct2.Print());

        }
    }

}
