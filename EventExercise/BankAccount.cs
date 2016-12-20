using System;

namespace EventExercise
{
    public class BankAccount
    {
        public int Balance { get; set; }

        public event EventHandler<BankAccountEventArgs> Overdrawn;

        public BankAccount(int initialAmount)
        {            
            Balance = initialAmount;
            Console.WriteLine($"Initial amount: {initialAmount}");
        }

        public void AddFunds(int additonalMonies)
        {
            Balance += additonalMonies;
        }

        public bool Withdraw(int withdrawalAmount)
        {
            Console.WriteLine($"Attempting to withdraw {withdrawalAmount}");
            if (Balance >= withdrawalAmount)
            {
                Balance -= withdrawalAmount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {Balance}");
                return true;
            }

            Console.WriteLine("Withdrawal failed.");
            OnOverdrawn(new BankAccountEventArgs { OriginalBalance = Balance });

            return false;            
        }

        protected virtual void OnOverdrawn(BankAccountEventArgs eventArgs)
        {
            Overdrawn?.Invoke(this, eventArgs);
        }
    }

    public class BankAccountEventArgs : EventArgs
    {
        public int OriginalBalance { get; set; }
    }
}