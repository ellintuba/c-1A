using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address(8,11,"London","England");
           Account account1 = new Account( "Eion Morgan", 20000, address1);
           account1.ShowAccountInformation();

           Address address2 = new Address(9, 112, "Khulna","Bangladesh");
           Account account2 = new Account("Tamim", 7000, address2);

            
            account1.Withdraw(500);
            account1.Deposite(1000);
           // account1.Transfer(account2,300);


           
            account2.ShowAccountInformation();
            account2.Withdraw(8000);
            account2.Deposite(0);
            Console.ReadKey();

           // Account account2 = new Account(1002,"Tamim",3000,new Address(7,20,"Chittagong"));
            //account2.PrintAccount();

           //  Bank ourBank = new Bank("Developer's bank", 5);
            // ourBank.AddAccount(new Account( "Shakib", 2000, new Address(4, 10, "Dhaka")));
         

          // ourBank.AddAccount(new Account( "Mushfiq", 5000, new Address(4, 10, "Sylhet")));
           // ourBank.AddAccount(new Account( "Tamim", 3000, new Address(7, 20, "Chittagong")));
           // ourBank.PrintAccountDetails();
            //ourBank.Withdraw(new Account ());
           // ourBank.SearchAccount(1001);
           
            
        }
    }
}
