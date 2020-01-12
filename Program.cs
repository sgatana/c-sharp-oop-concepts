using System;
using System.Collections.Generic;

namespace firstApp {
    class Program {
        static void Main (string[] args) {
            var account = new BankAccount ("Stephen", 550);
            try {
                account.MakeWithdrawal (500, DateTime.Now, "Rent payment");
                Console.WriteLine (account.Balance);

            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine ("An error Occurred");
                Console.WriteLine (e.ToString ());

            }
            account.MakeDeposit (100, DateTime.Now, "advance");
            Console.WriteLine (account.Balance);
            Console.WriteLine (account.GetAccountHistory ());
        }

    }
}