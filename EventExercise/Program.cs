using System;

namespace EventExercise
{
    public class Program
    {
        static void Main()
        {
            WorkOnBankAccount();
            WorkOnOverdraftAccount();
            Console.ReadLine();
        }

        private static void WorkOnOverdraftAccount()
        {
            var overdraftAccount = new OverdraftAccount(5000, 2000);

            overdraftAccount.Overdrawn += OverdraftAccountOverdrawn;

            overdraftAccount.SavingsAccount.Overdrawn += BankAccountOverdrawn;

            overdraftAccount.Withdraw(10000);
        }

        private static void BankAccountOverdrawn(object sender, BankAccountEventArgs eventArgs)
        {
            Console.WriteLine($"Not enough monies in Savings Account. Original Balance: {eventArgs.OriginalBalance}");
        }

        private static void OverdraftAccountOverdrawn(object sender, BankAccountEventArgs eventArgs)
        {
            Console.WriteLine($"Not enough monies in Overdraft Account. Original Balance: {eventArgs.OriginalBalance}");
        }

        private static void WorkOnBankAccount()
        {
            var bankAccount = new BankAccount(5000);

            bankAccount.Overdrawn +=
                (sender, args) =>
                {
                    Console.WriteLine($"Not enough monies. Original Balance: {args.OriginalBalance}"); 
                };

            bankAccount.Withdraw(6000);
        }
    }
}
